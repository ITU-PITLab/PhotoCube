﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ObjectCubeServer.Models.DataAccess;

namespace ObjectCubeServer.Migrations
{
    [DbContext(typeof(ObjectContext))]
    [Migration("20180927150958_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ObjectCubeServer.Models.DomainClasses.Object", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("CubeObject");
                });

            modelBuilder.Entity("ObjectCubeServer.Models.DomainClasses.ObjectTag", b =>
                {
                    b.Property<int>("ObjectId");

                    b.Property<int>("TagId");

                    b.HasKey("ObjectId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ObjectTags");
                });

            modelBuilder.Entity("ObjectCubeServer.Models.DomainClasses.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ObjectCubeServer.Models.DomainClasses.ObjectTag", b =>
                {
                    b.HasOne("ObjectCubeServer.Models.DomainClasses.Object", "Object")
                        .WithMany("ObjectTags")
                        .HasForeignKey("ObjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ObjectCubeServer.Models.DomainClasses.Tag", "Tag")
                        .WithMany("ObjectTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}