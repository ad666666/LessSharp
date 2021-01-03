﻿using AutoMapper;
using LessSharp.Common;
using LessSharp.Common.CacheHelper;
using LessSharp.Data;
using LessSharp.Dto.Sys;
using LessSharp.Entity.Sys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessSharp.Service.Sys
{
    public class TokenService : EntityService<TokenDto, TokenDto, TokenDto, TokenQueryDto, Token, string>
    {
        private readonly AuthContext _authContext;
        private readonly ICacheHelper _cacheHelper;
        public static string DisabledTokenCacheKey = "DisabledToken";
        public TokenService(AppDbContext appDbContext, AuthContext authContext, ICacheHelper cacheHelper, IMapper mapper, IEnumerable<IEntityHandler<Token>> entityHandlers, IEnumerable<IQueryFilter<Token>> queryFilters) : base(appDbContext, mapper, entityHandlers, queryFilters)
        {
            _authContext = authContext;
            _cacheHelper = cacheHelper;
            IdFieldExpression = e => e.AccessToken;
            IsFindOldEntity = true;
            OrderDefaultField = e => e.CreateTime;
        }
        protected override void OnCreating(Token entity, TokenDto createDto)
        {
            entity.Ip = _authContext.UserIP.ToString();
        }
        protected override IQueryable<Token> OnFilter(IQueryable<Token> query, TokenQueryDto queryDto)
        {
            query = base.OnFilter(query, queryDto);
            if (!string.IsNullOrEmpty(queryDto.UserLoginName))
            {
                query = query.Where(e => e.User.LoginName.Contains(queryDto.UserLoginName));
            }
            if (!string.IsNullOrEmpty(queryDto.AccessToken))
            {
                query = query.Where(e => e.AccessToken.Contains(queryDto.AccessToken));
            }
            if (!string.IsNullOrEmpty(queryDto.RefreshToken))
            {
                query = query.Where(e => e.RefreshToken.Contains(queryDto.RefreshToken));
            }
            if (queryDto.InCacheDisabled.HasValue)
            {
                var disabledTokens = _cacheHelper.SetGet(DisabledTokenCacheKey);
                if (queryDto.InCacheDisabled.Value)
                {
                    query = query.Where(e => disabledTokens.Contains(e.AccessToken));
                }
                else
                {
                    query = query.Where(e => !disabledTokens.Contains(e.AccessToken));
                }

            }
            return query;
        }

        /// <summary>
        /// 禁用Token
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task DisableTokenAsync(string accessToken)
        {

            await this.UpdateEntityAsync(new Token
            {
                AccessToken = accessToken,
                IsDisabled = true
            }, new List<Expression<Func<Token, object>>> { e => e.IsDisabled }, false);
            _cacheHelper.SetAdd(DisabledTokenCacheKey, accessToken);
        }

        /// <summary>
        /// 根据用户Id禁用Token
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public async Task DisableTokenByUserIdAsync(int userId)
        {
            var tokens = await DbQuery.Where(e => e.UserId == userId && e.RefreshExpire >= DateTime.Now).Select(e => e.AccessToken).ToListAsync();
            tokens.ForEach(token =>
            {
                this.DisableTokenAsync(token).Wait();
            });
        }

        /// <summary>
        /// 重载已禁用的AccessToken到缓存中
        /// </summary>
        /// <returns></returns>
        public async Task ReloadDisabledTokenAsync()
        {
            var tokens = await DbQuery.Where(e => e.IsDisabled == true && e.AccessExpire > DateTime.Now).Select(e => e.AccessToken).ToListAsync();
            _cacheHelper.Delete(DisabledTokenCacheKey);
            if (tokens.Count > 0)
            {
                _cacheHelper.SetAdd(DisabledTokenCacheKey, tokens.ToArray());
            }

        }

    }
}
