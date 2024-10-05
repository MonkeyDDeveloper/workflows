﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PortfolioBackend.Context;

#nullable disable

namespace PortfolioBackend.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20241003003517_set_correct_relations")]
    partial class set_correct_relations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PortfolioBackend.Models.ProfessionalExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("professional_experiences", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Created a web application to streamline the student enrollment process.",
                            EndDate = new DateOnly(2022, 7, 31),
                            StartDate = new DateOnly(2021, 2, 1),
                            Title = "FullStack Developer at MonkeyDDevelopment"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Implemented Nomina360, a web app for human resources management.",
                            EndDate = new DateOnly(2023, 11, 30),
                            StartDate = new DateOnly(2022, 10, 1),
                            Title = "FullStack Developer at Soluciones y Proyectos SA"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Developed a client's page using the new version of Shopify Theme Dawn.",
                            EndDate = new DateOnly(2024, 2, 29),
                            StartDate = new DateOnly(2023, 11, 1),
                            Title = "Frontend Developer at CacaoWebStudio"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Created an application to manage the capacitation of operators in Yucatán, México.",
                            EndDate = new DateOnly(2024, 12, 31),
                            StartDate = new DateOnly(2024, 5, 1),
                            Title = "Software Engineer at Dacodes"
                        });
                });

            modelBuilder.Entity("PortfolioBackend.Models.Responsabilitie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("ExperienceId")
                        .HasColumnType("integer")
                        .HasColumnName("experience_id");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.ToTable("responsabilities", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Defining the current enrollment process and its weaknesses.",
                            ExperienceId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Design the pages and use cases, with focus on easy use for its users.",
                            ExperienceId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "Make reviews with the administrative staff and the students of the institute.",
                            ExperienceId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Define the correct structure of subjects, students, careers, admin users for the database.",
                            ExperienceId = 1
                        },
                        new
                        {
                            Id = 5,
                            Description = "Be responsible for the frontend, backend, database and release of the application.",
                            ExperienceId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Implement readable and clean code, following the best practices.",
                            ExperienceId = 2
                        },
                        new
                        {
                            Id = 7,
                            Description = "Analyze the requirements to implement them correctly.",
                            ExperienceId = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Realize unit testing of the functions created.",
                            ExperienceId = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Have great communication with the rest of the dev team, and also with the administrative team.",
                            ExperienceId = 2
                        },
                        new
                        {
                            Id = 10,
                            Description = "Realize code review of the tasks of the rest of the team.",
                            ExperienceId = 2
                        },
                        new
                        {
                            Id = 11,
                            Description = "Efficiently implement components, snippets, and sections of Shopify.",
                            ExperienceId = 3
                        },
                        new
                        {
                            Id = 12,
                            Description = "Testing every new section created to ensure its working in different screen sizes.",
                            ExperienceId = 3
                        },
                        new
                        {
                            Id = 13,
                            Description = "Priority user experience, make efficient js code.",
                            ExperienceId = 3
                        },
                        new
                        {
                            Id = 14,
                            Description = "Defining project structure.",
                            ExperienceId = 3
                        },
                        new
                        {
                            Id = 15,
                            Description = "Keep track of tasks and good communication with the designing and development team.",
                            ExperienceId = 3
                        },
                        new
                        {
                            Id = 16,
                            Description = "Ensure clean and understandable code (code review).",
                            ExperienceId = 3
                        },
                        new
                        {
                            Id = 17,
                            Description = "Create and implement Vuejs components using domain-driven-design.",
                            ExperienceId = 4
                        },
                        new
                        {
                            Id = 18,
                            Description = "Estimate the time to implement requirements in hours in meetings with the team.",
                            ExperienceId = 4
                        },
                        new
                        {
                            Id = 19,
                            Description = "Follow the business requirements and use cases.",
                            ExperienceId = 4
                        },
                        new
                        {
                            Id = 20,
                            Description = "Good communication with the QA and development team.",
                            ExperienceId = 4
                        },
                        new
                        {
                            Id = 21,
                            Description = "Ensure clean and understandable code and code refactorization.",
                            ExperienceId = 4
                        },
                        new
                        {
                            Id = 22,
                            Description = "Side help with Backend code analysis and DB.",
                            ExperienceId = 4
                        });
                });

            modelBuilder.Entity("PortfolioBackend.Models.Technologie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("technologies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nuxt 3.10.2"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vue.js 3.4.x"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vue.js 2.7"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Vuetify 2.6"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bootstrap 4.x"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Nuxt/ui 2.13.0"
                        },
                        new
                        {
                            Id = 7,
                            Name = "TailwindCSS 3.4.1"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Zod 3.2.24"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Node 20.0.0"
                        },
                        new
                        {
                            Id = 10,
                            Name = "PostgreSQL 12"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Git"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Docker"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Nuxt 3.10.2"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Vue.js 3.4.x"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Nuxt/ui 2.13.0"
                        },
                        new
                        {
                            Id = 16,
                            Name = "TailwindCSS 3.4.1"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Zod 3.2.24"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Node 20.0.0"
                        },
                        new
                        {
                            Id = 19,
                            Name = "i18n 8.1.1"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Resend 3.2.0"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Shopify Dawn 13.0.1"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Liquid Template Language 5.4.0"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Git"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Vue.js 3.2.3"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Node 10.24.0"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Quasar Framework 0.17"
                        },
                        new
                        {
                            Id = 27,
                            Name = "MongoDB 5.0"
                        },
                        new
                        {
                            Id = 28,
                            Name = "TypeScript 5.4"
                        },
                        new
                        {
                            Id = 29,
                            Name = "JavaScript (Vanilla)"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Pug.js (HTML)"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Bootstrap 5.0"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Node.js 14.0.0"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Express 4.0"
                        },
                        new
                        {
                            Id = 34,
                            Name = "MongoDB 5.0"
                        },
                        new
                        {
                            Id = 35,
                            Name = "DigitalOcean"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Nginx"
                        },
                        new
                        {
                            Id = 37,
                            Name = "NameCheap"
                        });
                });

            modelBuilder.Entity("PortfolioBackend.Models.TechnologieExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ExperienceId")
                        .HasColumnType("integer")
                        .HasColumnName("experience_id");

                    b.Property<int>("TechnologieId")
                        .HasColumnType("integer")
                        .HasColumnName("technologie_id");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("TechnologieId");

                    b.ToTable("technologies_experiences", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExperienceId = 4,
                            TechnologieId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExperienceId = 4,
                            TechnologieId = 2
                        },
                        new
                        {
                            Id = 3,
                            ExperienceId = 4,
                            TechnologieId = 3
                        },
                        new
                        {
                            Id = 4,
                            ExperienceId = 4,
                            TechnologieId = 4
                        },
                        new
                        {
                            Id = 5,
                            ExperienceId = 4,
                            TechnologieId = 5
                        },
                        new
                        {
                            Id = 6,
                            ExperienceId = 4,
                            TechnologieId = 6
                        },
                        new
                        {
                            Id = 7,
                            ExperienceId = 4,
                            TechnologieId = 7
                        },
                        new
                        {
                            Id = 8,
                            ExperienceId = 4,
                            TechnologieId = 8
                        },
                        new
                        {
                            Id = 9,
                            ExperienceId = 4,
                            TechnologieId = 9
                        },
                        new
                        {
                            Id = 10,
                            ExperienceId = 4,
                            TechnologieId = 10
                        },
                        new
                        {
                            Id = 11,
                            ExperienceId = 4,
                            TechnologieId = 11
                        },
                        new
                        {
                            Id = 12,
                            ExperienceId = 4,
                            TechnologieId = 12
                        },
                        new
                        {
                            Id = 13,
                            ExperienceId = 3,
                            TechnologieId = 13
                        },
                        new
                        {
                            Id = 14,
                            ExperienceId = 3,
                            TechnologieId = 14
                        },
                        new
                        {
                            Id = 15,
                            ExperienceId = 3,
                            TechnologieId = 16
                        },
                        new
                        {
                            Id = 16,
                            ExperienceId = 3,
                            TechnologieId = 17
                        },
                        new
                        {
                            Id = 17,
                            ExperienceId = 3,
                            TechnologieId = 18
                        },
                        new
                        {
                            Id = 18,
                            ExperienceId = 3,
                            TechnologieId = 19
                        },
                        new
                        {
                            Id = 19,
                            ExperienceId = 3,
                            TechnologieId = 20
                        },
                        new
                        {
                            Id = 20,
                            ExperienceId = 3,
                            TechnologieId = 21
                        },
                        new
                        {
                            Id = 21,
                            ExperienceId = 3,
                            TechnologieId = 22
                        },
                        new
                        {
                            Id = 22,
                            ExperienceId = 2,
                            TechnologieId = 24
                        },
                        new
                        {
                            Id = 23,
                            ExperienceId = 2,
                            TechnologieId = 25
                        },
                        new
                        {
                            Id = 24,
                            ExperienceId = 2,
                            TechnologieId = 26
                        },
                        new
                        {
                            Id = 25,
                            ExperienceId = 2,
                            TechnologieId = 27
                        },
                        new
                        {
                            Id = 26,
                            ExperienceId = 2,
                            TechnologieId = 28
                        },
                        new
                        {
                            Id = 27,
                            ExperienceId = 1,
                            TechnologieId = 29
                        },
                        new
                        {
                            Id = 28,
                            ExperienceId = 1,
                            TechnologieId = 30
                        },
                        new
                        {
                            Id = 29,
                            ExperienceId = 1,
                            TechnologieId = 31
                        },
                        new
                        {
                            Id = 30,
                            ExperienceId = 1,
                            TechnologieId = 32
                        },
                        new
                        {
                            Id = 31,
                            ExperienceId = 1,
                            TechnologieId = 33
                        },
                        new
                        {
                            Id = 32,
                            ExperienceId = 1,
                            TechnologieId = 34
                        },
                        new
                        {
                            Id = 33,
                            ExperienceId = 1,
                            TechnologieId = 35
                        },
                        new
                        {
                            Id = 34,
                            ExperienceId = 1,
                            TechnologieId = 36
                        },
                        new
                        {
                            Id = 35,
                            ExperienceId = 1,
                            TechnologieId = 37
                        });
                });

            modelBuilder.Entity("PortfolioBackend.Models.Responsabilitie", b =>
                {
                    b.HasOne("PortfolioBackend.Models.ProfessionalExperience", "ProfessionalExperience")
                        .WithMany("Responsabilities")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfessionalExperience");
                });

            modelBuilder.Entity("PortfolioBackend.Models.TechnologieExperience", b =>
                {
                    b.HasOne("PortfolioBackend.Models.ProfessionalExperience", "ProfessionalExperience")
                        .WithMany("TechnologieExperiences")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortfolioBackend.Models.Technologie", "Technologie")
                        .WithMany()
                        .HasForeignKey("TechnologieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfessionalExperience");

                    b.Navigation("Technologie");
                });

            modelBuilder.Entity("PortfolioBackend.Models.ProfessionalExperience", b =>
                {
                    b.Navigation("Responsabilities");

                    b.Navigation("TechnologieExperiences");
                });
#pragma warning restore 612, 618
        }
    }
}
