﻿// <auto-generated />
using System;
using LessSharp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LessSharp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200713151816_faf07d62-7868-4e77-b361-38d4668bbaa6")]
    partial class faf07d6278684e77b36138d4668bbaa6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LessSharp.Entity.Attach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnName("delete_time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteUserId")
                        .HasColumnName("delete_user_id")
                        .HasColumnType("int");

                    b.Property<Guid>("EntityGuid")
                        .HasColumnName("entity_guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityName")
                        .HasColumnName("entity_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ext")
                        .HasColumnName("ext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnName("is_public")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnName("path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnName("size")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnName("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("attach");
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.Api", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsCommon")
                        .HasColumnName("is_common")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Path")
                        .HasColumnName("path")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PermissionType")
                        .HasColumnName("permission_type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[name] IS NOT NULL");

                    b.HasIndex("Path")
                        .IsUnique()
                        .HasFilter("[path] IS NOT NULL");

                    b.ToTable("sys_api");
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.Config", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnName("key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("sys_config");

                    b.HasData(
                        new
                        {
                            Key = "SYSTEM_TITLE",
                            Name = "系统标题",
                            Type = "STRING",
                            Value = "LessAdmin快速开发框架"
                        },
                        new
                        {
                            Key = "MENU_BAR_TITLE",
                            Name = "菜单栏标题",
                            Type = "STRING",
                            Value = "LessAdmin"
                        },
                        new
                        {
                            Key = "VERSION",
                            Name = "版本号",
                            Type = "STRING",
                            Value = "20200414001"
                        },
                        new
                        {
                            Key = "IS_REPAIR",
                            Name = "网站维护",
                            Type = "BOOL",
                            Value = "OFF"
                        },
                        new
                        {
                            Key = "LAYOUT",
                            Name = "后台布局",
                            Type = "STRING",
                            Value = "leftRight"
                        },
                        new
                        {
                            Key = "LIST_DEFAULT_PAGE_SIZE",
                            Name = "列表默认页容量",
                            Type = "NUMBER",
                            Value = "10"
                        },
                        new
                        {
                            Key = "MENU_DEFAULT_ICON",
                            Name = "菜单默认图标",
                            Type = "STRING",
                            Value = "el-icon-menu"
                        },
                        new
                        {
                            Key = "SHOW_MENU_ICON",
                            Name = "是否显示菜单图标",
                            Type = "BOOL",
                            Value = "OFF"
                        },
                        new
                        {
                            Key = "LOGIN_VCODE",
                            Name = "登录需要验证码",
                            Type = "BOOL",
                            Value = "OFF"
                        },
                        new
                        {
                            Key = "PAGE_TABS",
                            Name = "使用多页面标签",
                            Type = "BOOL",
                            Value = "ON"
                        });
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanMultipleOpen")
                        .HasColumnName("can_multiple_open")
                        .HasColumnType("bit");

                    b.Property<bool>("HasRead")
                        .HasColumnName("has_read")
                        .HasColumnType("bit");

                    b.Property<bool>("HasReview")
                        .HasColumnName("has_review")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWrite")
                        .HasColumnName("has_write")
                        .HasColumnType("bit");

                    b.Property<string>("Icon")
                        .HasColumnName("icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPage")
                        .HasColumnName("is_page")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnName("order")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnName("parent_id")
                        .HasColumnType("int");

                    b.Property<string>("ParentIds")
                        .HasColumnName("parent_ids")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnName("path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sys_menu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CanMultipleOpen = false,
                            HasRead = false,
                            HasReview = false,
                            HasWrite = false,
                            IsPage = false,
                            Name = "系统管理",
                            Order = 99,
                            Path = "sys"
                        },
                        new
                        {
                            Id = 2,
                            CanMultipleOpen = false,
                            HasRead = false,
                            HasReview = false,
                            HasWrite = false,
                            IsPage = false,
                            Name = "用户管理",
                            Order = 1,
                            ParentId = 1,
                            ParentIds = "1",
                            Path = "user"
                        },
                        new
                        {
                            Id = 3,
                            CanMultipleOpen = false,
                            HasRead = false,
                            HasReview = false,
                            HasWrite = false,
                            IsPage = false,
                            Name = "角色管理",
                            Order = 2,
                            ParentId = 1,
                            ParentIds = "1",
                            Path = "role"
                        },
                        new
                        {
                            Id = 4,
                            CanMultipleOpen = false,
                            HasRead = false,
                            HasReview = false,
                            HasWrite = false,
                            IsPage = false,
                            Name = "菜单管理",
                            Order = 3,
                            ParentId = 1,
                            ParentIds = "1",
                            Path = "menu"
                        },
                        new
                        {
                            Id = 5,
                            CanMultipleOpen = false,
                            HasRead = false,
                            HasReview = false,
                            HasWrite = false,
                            IsPage = false,
                            Name = "接口管理",
                            Order = 4,
                            ParentId = 1,
                            ParentIds = "1",
                            Path = "api"
                        });
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.MenuApi", b =>
                {
                    b.Property<int>("ApiId")
                        .HasColumnName("api_id")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnName("menu_id")
                        .HasColumnType("int");

                    b.HasKey("ApiId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("sys_menu_api");
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Remarks")
                        .HasColumnName("remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[name] IS NOT NULL");

                    b.ToTable("sys_role");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "超级角色",
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.RoleMenu", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnName("menu_id")
                        .HasColumnType("int");

                    b.Property<bool>("CanRead")
                        .HasColumnName("can_read")
                        .HasColumnType("bit");

                    b.Property<bool>("CanReview")
                        .HasColumnName("can_review")
                        .HasColumnType("bit");

                    b.Property<bool>("CanWrite")
                        .HasColumnName("can_write")
                        .HasColumnType("bit");

                    b.HasKey("RoleId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("sys_role_menu");
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDisabled")
                        .HasColumnName("is_disabled")
                        .HasColumnType("bit");

                    b.Property<string>("LoginName")
                        .HasColumnName("login_name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginPassword")
                        .HasColumnName("login_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnName("update_time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LoginName")
                        .IsUnique()
                        .HasFilter("[login_name] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.ToTable("sys_user");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CreateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDisabled = false,
                            LoginName = "superadmin",
                            LoginPassword = "admin",
                            RoleId = -1,
                            UpdateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.UserLoginLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("create_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserId")
                        .HasColumnName("create_user_id")
                        .HasColumnType("int");

                    b.Property<string>("IpAddress")
                        .HasColumnName("ip_address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreateUserId");

                    b.ToTable("sys_user_login_log");
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.MenuApi", b =>
                {
                    b.HasOne("LessSharp.Entity.Sys.Api", "Api")
                        .WithMany("MenuApis")
                        .HasForeignKey("ApiId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LessSharp.Entity.Sys.Menu", "Menu")
                        .WithMany("MenuApis")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.RoleMenu", b =>
                {
                    b.HasOne("LessSharp.Entity.Sys.Menu", "Menu")
                        .WithMany("RoleMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LessSharp.Entity.Sys.Role", "Role")
                        .WithMany("RoleMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.User", b =>
                {
                    b.HasOne("LessSharp.Entity.Sys.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("LessSharp.Entity.Sys.UserLoginLog", b =>
                {
                    b.HasOne("LessSharp.Entity.Sys.User", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
