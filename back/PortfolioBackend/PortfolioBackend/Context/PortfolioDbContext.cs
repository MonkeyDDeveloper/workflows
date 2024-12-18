
using Microsoft.EntityFrameworkCore;
using PortfolioBackend.Models;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace PortfolioBackend.Context
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<ProfessionalExperience> ProfessionalExperiences { get; set; }
        public DbSet<Responsabilitie> Responsabilities { get; set; }
        public DbSet<Technologie> Technologies { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public DbSet<TechnologieExperience> TechnologiesExperiences { get; set; }
        public DbSet<CompanyExperience> CompanyExperiences { get; set; }

        public required string postgresConnectionString { get; set; }

        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TechnologieExperience>()
                .HasOne(te => te.Technologie);

            builder.Entity<TechnologieExperience>()
                .HasOne(te => te.ProfessionalExperience)
                .WithMany(pe => pe.TechnologieExperiences)
                .HasForeignKey(te => te.ExperienceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Responsabilitie>()
                .HasOne(re => re.ProfessionalExperience)
                .WithMany(pe => pe.Responsabilities)
                .HasForeignKey(re => re.ExperienceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProfessionalExperience>()
                .HasMany(pe => pe.TechnologieExperiences);

            builder.Entity<ProfessionalExperience>()
                .HasMany(pe => pe.Responsabilities)
                .WithOne(re => re.ProfessionalExperience)
                .HasForeignKey(re => re.ExperienceId)
                .HasPrincipalKey(pe => pe.Id);

            builder.Entity<ProfessionalExperience>()
                .ToTable("professional_experiences");

            builder.Entity<Technologie>()
                .ToTable("technologies");

            builder.Entity<TechnologieExperience>()
                .ToTable("technologies_experiences");

            builder.Entity<Responsabilitie>()
                .ToTable("responsabilities");

            builder.Entity<Project>()
                .ToTable("projects");

            builder.Entity<Company>()
                .ToTable("companies");

            builder.Entity<CompanyExperience>()
                .ToTable("company_experiences");

            builder.Entity<ProjectTask>()
                .ToTable("project_tasks");

            builder.Entity<Project>()
                .HasMany(p => p.ProjectTasks)
                .WithOne(pt => pt.Project);

            builder.Entity<Project>()
                .HasMany(p => p.ProjectTechnologies)
                .WithOne(tp => tp.Project);

            builder.Entity<ProjectTask>()
                .HasOne(pt => pt.Project);

            builder.Entity<TechnologieProject>()
                .HasOne(tp => tp.Project);

            builder.Entity<TechnologieProject>()
                .HasOne(tp => tp.Technologie);

            builder.Entity<ProfessionalExperience>()
                .HasOne(pe => pe.CompanyExperience)
                .WithOne(ce => ce.ProfessionalExperience);

            builder.Entity<CompanyExperience>()
                .HasOne(ce => ce.ProfessionalExperience);

            builder.Entity<CompanyExperience>()
                .HasOne(ce => ce.Company);

            // Initial data for companies

            builder.Entity<Company>().HasData(
                new Company() { Id = 4, Name = "Dacodes", LogoPath = "/experience/dacodes_logo.webp" },
                new Company() { Id = 2, Name = "Soluciones y Proyectos SA", LogoPath = "/experience/nomina360.png" },
                new Company() { Id = 3, Name = "Cacao Web Studio", LogoPath = "/experience/cacao_logo.jpg" },
                new Company() { Id = 1, Name = "MonkeyDDeveloper", LogoPath = "/experience/monkey_d_developer.png" }
            );

            // Initial data for experiences
            builder.Entity<ProfessionalExperience>().HasData(
                new ProfessionalExperience
                {
                    Id = 1,
                    Title = "FullStack Developer at MonkeyDDevelopment",
                    Description = "We created a web application to streamline the student enrollment process.",
                    StartDate = new DateOnly(2021, 2, 1),
                    EndDate = new DateOnly(2022, 7, 31)
                },
                new ProfessionalExperience
                {
                    Id = 2,
                    Title = "FullStack Developer at Soluciones y Proyectos SA",
                    Description = "Implemented Nomina360, a web app for human resources management.",
                    StartDate = new DateOnly(2022, 10, 1),
                    EndDate = new DateOnly(2023, 11, 30)
                },
                new ProfessionalExperience
                {
                    Id = 3,
                    Title = "Frontend Developer at CacaoWebStudio",
                    Description = "Developed a client's page using the new version of Shopify Theme Dawn.",
                    StartDate = new DateOnly(2023, 11, 1),
                    EndDate = new DateOnly(2024, 2, 29)
                },
                new ProfessionalExperience
                {
                    Id = 4,
                    Title = "Software Engineer at Dacodes",
                    Description = "Created an application to manage the capacitation of operators in Yucatán, México.",
                    StartDate = new DateOnly(2024, 5, 1),
                    EndDate = new DateOnly(2024, 12, 31),
                    IsCurrent = true
                }
            );

            builder.Entity<Responsabilitie>().HasData(
                // FullStack Developer at MonkeyDDevelopment
                new Responsabilitie { Id = 1, ExperienceId = 1, Description = "Defining the current enrollment process and its weaknesses." },
                new Responsabilitie { Id = 2, ExperienceId = 1, Description = "Design the pages and use cases, with focus on easy use for its users." },
                new Responsabilitie { Id = 3, ExperienceId = 1, Description = "Make reviews with the administrative staff and the students of the institute." },
                new Responsabilitie { Id = 4, ExperienceId = 1, Description = "Define the correct structure of subjects, students, careers, admin users for the database." },
                new Responsabilitie { Id = 5, ExperienceId = 1, Description = "Be responsible for the frontend, backend, database and release of the application." },

                // FullStack Developer at Soluciones y Proyectos SA
                new Responsabilitie { Id = 6, ExperienceId = 2, Description = "Implement readable and clean code, following the best practices." },
                new Responsabilitie { Id = 7, ExperienceId = 2, Description = "Analyze the requirements to implement them correctly." },
                new Responsabilitie { Id = 8, ExperienceId = 2, Description = "Realize unit testing of the functions created." },
                new Responsabilitie { Id = 9, ExperienceId = 2, Description = "Have great communication with the rest of the dev team, and also with the administrative team." },
                new Responsabilitie { Id = 10, ExperienceId = 2, Description = "Realize code review of the tasks of the rest of the team." },

                // Frontend Developer at CacaoWebStudio
                new Responsabilitie { Id = 11, ExperienceId = 3, Description = "Efficiently implement components, snippets, and sections of Shopify." },
                new Responsabilitie { Id = 12, ExperienceId = 3, Description = "Testing every new section created to ensure its working in different screen sizes." },
                new Responsabilitie { Id = 13, ExperienceId = 3, Description = "Priority user experience, make efficient js code." },
                new Responsabilitie { Id = 14, ExperienceId = 3, Description = "Defining project structure." },
                new Responsabilitie { Id = 15, ExperienceId = 3, Description = "Keep track of tasks and good communication with the designing and development team." },
                new Responsabilitie { Id = 16, ExperienceId = 3, Description = "Ensure clean and understandable code (code review)." },

                // Software Engineer at Dacodes
                new Responsabilitie { Id = 17, ExperienceId = 4, Description = "Create and implement Vuejs components using domain-driven-design." },
                new Responsabilitie { Id = 18, ExperienceId = 4, Description = "Estimate the time to implement requirements in hours in meetings with the team." },
                new Responsabilitie { Id = 19, ExperienceId = 4, Description = "Follow the business requirements and use cases." },
                new Responsabilitie { Id = 20, ExperienceId = 4, Description = "Good communication with the QA and development team." },
                new Responsabilitie { Id = 21, ExperienceId = 4, Description = "Ensure clean and understandable code and code refactorization." },
                new Responsabilitie { Id = 22, ExperienceId = 4, Description = "Side help with Backend code analysis and DB." }
            );

            builder.Entity<Technologie>().HasData(
                // Tecnologías de Dacodes
                new Technologie { Id = 1, Name = "Nuxt 3.10.2", Abbr = "nuxt" },
                new Technologie { Id = 2, Name = "Vue.js 3.4.x", Abbr = "vue"},
                new Technologie { Id = 3, Name = "Vue.js 2.7", Abbr = "vue" },
                new Technologie { Id = 4, Name = "Vuetify 2.6", Abbr = "vuetify"},
                new Technologie { Id = 5, Name = "Bootstrap 4.x", Abbr = "bootstrap" },
                new Technologie { Id = 6, Name = "Nuxt/ui 2.13.0", Abbr = "nuxtui" },
                new Technologie { Id = 7, Name = "TailwindCSS 3.4.1", Abbr = "tailwind" },
                new Technologie { Id = 8, Name = "Zod 3.2.24", Abbr = "zod" },
                new Technologie { Id = 9, Name = "Node 20.0.0", Abbr = "node" },
                new Technologie { Id = 10, Name = "PostgreSQL 12", Abbr = "postgres" },
                new Technologie { Id = 11, Name = "Git", Abbr = "git" },
                new Technologie { Id = 12, Name = "Docker", Abbr = "docker" },

                // Tecnologías de CacaoWebStudio
                new Technologie { Id = 13, Name = "Nuxt 3.10.2", Abbr = "nuxt" },
                new Technologie { Id = 14, Name = "Vue.js 3.4.x", Abbr = "vue" },
                new Technologie { Id = 15, Name = "Nuxt/ui 2.13.0", Abbr = "nuxtui" },
                new Technologie { Id = 16, Name = "TailwindCSS 3.4.1", Abbr = "tailwind" },
                new Technologie { Id = 17, Name = "Zod 3.2.24", Abbr = "zod" },
                new Technologie { Id = 18, Name = "Node 20.0.0", Abbr = "node" },
                new Technologie { Id = 19, Name = "i18n 8.1.1", Abbr = "i18n" },
                new Technologie { Id = 20, Name = "Resend 3.2.0", Abbr = "resend" },
                new Technologie { Id = 21, Name = "Shopify Dawn 13.0.1", Abbr = "shopify" },
                new Technologie { Id = 22, Name = "Liquid Template Language 5.4.0", Abbr = "liquidtemplate" },
                new Technologie { Id = 23, Name = "Git", Abbr = "git" },

                // Tecnologías de Soluciones y Proyectos SA
                new Technologie { Id = 24, Name = "Vue.js 3.2.3", Abbr = "vue" },
                new Technologie { Id = 25, Name = "Node 10.24.0", Abbr = "node" },
                new Technologie { Id = 26, Name = "Quasar Framework 0.17", Abbr = "quasar" },
                new Technologie { Id = 27, Name = "MongoDB 5.0", Abbr = "mongo" },
                new Technologie { Id = 28, Name = "TypeScript 5.4", Abbr = "typescript" },

                // Tecnologías de MonkeyDevelopment
                new Technologie { Id = 29, Name = "JavaScript (Vanilla)", Abbr = "javascript" },
                new Technologie { Id = 30, Name = "Pug.js (HTML)", Abbr = "pugjs" },
                new Technologie { Id = 31, Name = "Bootstrap 5.0", Abbr = "bootstrap" },
                new Technologie { Id = 32, Name = "Node.js 14.0.0", Abbr = "node" },
                new Technologie { Id = 33, Name = "Express 4.0", Abbr = "express" },
                new Technologie { Id = 34, Name = "MongoDB 5.0", Abbr = "mongo" },
                new Technologie { Id = 35, Name = "DigitalOcean", Abbr = "digitalocean" },
                new Technologie { Id = 36, Name = "Nginx", Abbr = "nginx" },
                new Technologie { Id = 37, Name = "NameCheap", Abbr = "namecheap" },

                // Otras tecnologías
                new Technologie { Id = 38, Name = "JsonWebTokens", Abbr = "jwt" },
                new Technologie { Id = 39, Name = "Python 3.10.12", Abbr = "python" },
                new Technologie { Id = 40, Name = "Flask 3.0.3", Abbr = "flask" },
                new Technologie { Id = 41, Name = "PyMongo 4.7.2", Abbr = "pymongo" },
                new Technologie { Id = 42, Name = "Mongoose", Abbr = "mongoose" },
                new Technologie { Id = 43, Name = "AWS API Gateway", Abbr = "awsgateway" },
                new Technologie { Id = 44, Name = "AWS Lambda Functions", Abbr = "awslambda" },
                new Technologie { Id = 45, Name = "Nextjs", Abbr = "nextjs" },
                new Technologie { Id = 46, Name = "PostgreSQL", Abbr = "postgres" },
                new Technologie { Id = 47, Name = ".NET 8", Abbr = "DotNET" },
                new Technologie { Id = 48, Name = "Entity Framework", Abbr = "entityframework" },
                new Technologie { Id = 49, Name = "Digital Ocean Droplets", Abbr = "digitalocean" },
                new Technologie { Id = 50, Name = "Github Actions", Abbr = "githubactions" },
                new Technologie { Id = 51, Name = "Redis", Abbr = "redis" },
                new Technologie { Id = 52, Name = "Swagger", Abbr = "swagger" },
                new Technologie { Id = 53, Name = "Jest", Abbr = "jest" },
                new Technologie { Id = 54, Name = "Axios", Abbr = "axios" }
            );

            builder.Entity<TechnologieExperience>().HasData(
                // Tecnologías para Dacodes
                new TechnologieExperience { Id = 1, TechnologieId = 1, ExperienceId = 4 }, // Nuxt 3.10.2 - Dacodes
                new TechnologieExperience { Id = 2, TechnologieId = 2, ExperienceId = 4 }, // Vue.js 3.4.x - Dacodes
                new TechnologieExperience { Id = 3, TechnologieId = 3, ExperienceId = 4 }, // Vue.js 2.7 - Dacodes
                new TechnologieExperience { Id = 4, TechnologieId = 4, ExperienceId = 4 }, // Vuetify 2.6 - Dacodes
                new TechnologieExperience { Id = 5, TechnologieId = 5, ExperienceId = 4 }, // Bootstrap 4.x - Dacodes
                new TechnologieExperience { Id = 6, TechnologieId = 6, ExperienceId = 4 }, // Nuxt/ui 2.13.0 - Dacodes
                new TechnologieExperience { Id = 7, TechnologieId = 7, ExperienceId = 4 }, // TailwindCSS 3.4.1 - Dacodes
                new TechnologieExperience { Id = 8, TechnologieId = 8, ExperienceId = 4 }, // Zod 3.2.24 - Dacodes
                new TechnologieExperience { Id = 9, TechnologieId = 9, ExperienceId = 4 }, // Node 20.0.0 - Dacodes
                new TechnologieExperience { Id = 10, TechnologieId = 10, ExperienceId = 4 }, // PostgreSQL 12 - Dacodes
                new TechnologieExperience { Id = 11, TechnologieId = 11, ExperienceId = 4 }, // Git - Dacodes
                new TechnologieExperience { Id = 12, TechnologieId = 12, ExperienceId = 4 }, // Docker - Dacodes

                // Tecnologías para CacaoWebStudio
                new TechnologieExperience { Id = 13, TechnologieId = 13, ExperienceId = 3 }, // Nuxt 3.10.2 - CacaoWebStudio
                new TechnologieExperience { Id = 14, TechnologieId = 14, ExperienceId = 3 }, // Vue.js 3.4.x - CacaoWebStudio
                new TechnologieExperience { Id = 15, TechnologieId = 16, ExperienceId = 3 }, // TailwindCSS 3.4.1 - CacaoWebStudio
                new TechnologieExperience { Id = 16, TechnologieId = 17, ExperienceId = 3 }, // Zod 3.2.24 - CacaoWebStudio
                new TechnologieExperience { Id = 17, TechnologieId = 18, ExperienceId = 3 }, // Node 20.0.0 - CacaoWebStudio
                new TechnologieExperience { Id = 18, TechnologieId = 19, ExperienceId = 3 }, // i18n 8.1.1 - CacaoWebStudio
                new TechnologieExperience { Id = 19, TechnologieId = 20, ExperienceId = 3 }, // Resend 3.2.0 - CacaoWebStudio
                new TechnologieExperience { Id = 20, TechnologieId = 21, ExperienceId = 3 }, // Shopify Dawn 13.0.1 - CacaoWebStudio
                new TechnologieExperience { Id = 21, TechnologieId = 22, ExperienceId = 3 }, // Liquid Template Language 5.4.0 - CacaoWebStudio

                // Tecnologías para Soluciones y Proyectos SA
                new TechnologieExperience { Id = 22, TechnologieId = 24, ExperienceId = 2 }, // Vue.js 3.2.3 - Soluciones y Proyectos SA
                new TechnologieExperience { Id = 23, TechnologieId = 25, ExperienceId = 2 }, // Node 10.24.0 - Soluciones y Proyectos SA
                new TechnologieExperience { Id = 24, TechnologieId = 26, ExperienceId = 2 }, // Quasar Framework 0.17 - Soluciones y Proyectos SA
                new TechnologieExperience { Id = 25, TechnologieId = 27, ExperienceId = 2 }, // MongoDB 5.0 - Soluciones y Proyectos SA
                new TechnologieExperience { Id = 26, TechnologieId = 28, ExperienceId = 2 }, // TypeScript 5.4 - Soluciones y Proyectos SA
                new TechnologieExperience { Id = 36, TechnologieId = 53, ExperienceId = 2 }, // TypeScript 5.4 - Soluciones y Proyectos SA
                new TechnologieExperience { Id = 37, TechnologieId = 52, ExperienceId = 2 }, // TypeScript 5.4 - Soluciones y Proyectos SA

                // Tecnologías para MonkeyDevelopment
                new TechnologieExperience { Id = 27, TechnologieId = 29, ExperienceId = 1 }, // JavaScript (Vanilla) - MonkeyDevelopment
                new TechnologieExperience { Id = 28, TechnologieId = 30, ExperienceId = 1 }, // Pug.js (HTML) - MonkeyDevelopment
                new TechnologieExperience { Id = 29, TechnologieId = 31, ExperienceId = 1 }, // Bootstrap 5.0 - MonkeyDevelopment
                new TechnologieExperience { Id = 30, TechnologieId = 32, ExperienceId = 1 }, // Node.js 14.0.0 - MonkeyDevelopment
                new TechnologieExperience { Id = 31, TechnologieId = 33, ExperienceId = 1 }, // Express 4.0 - MonkeyDevelopment
                new TechnologieExperience { Id = 32, TechnologieId = 34, ExperienceId = 1 }, // MongoDB 5.0 - MonkeyDevelopment
                new TechnologieExperience { Id = 33, TechnologieId = 35, ExperienceId = 1 }, // DigitalOcean - MonkeyDevelopment
                new TechnologieExperience { Id = 34, TechnologieId = 36, ExperienceId = 1 }, // Nginx - MonkeyDevelopment
                new TechnologieExperience { Id = 35, TechnologieId = 37, ExperienceId = 1 }  // NameCheap - MonkeyDevelopment
            );

            builder.Entity<CompanyExperience>().HasData(
                new CompanyExperience() { Id = 1, CompanyId = 1, ExperienceId = 1 },    
                new CompanyExperience() { Id = 2, CompanyId = 2, ExperienceId = 2 },    
                new CompanyExperience() { Id = 3, CompanyId = 3, ExperienceId = 3 },    
                new CompanyExperience() { Id = 4, CompanyId = 4, ExperienceId = 4 }
            );

            // Initial data for projects

            builder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "Dockerized Product Management System with Authentication", Description = "Full stack application that uses JWT to auth. The front was built with Nuxtjs and the back with express, both of them usgin typescript. It is dockerized and uses a Mongo Database. ", GithubUri = "https://github.com/MonkeyDDeveloper/dockerized-full-stack-application" },
                new Project { Id = 2, Name = "Dockerized Python Flask Rest Api - MongoDB", Description = "An example of rest api using Flask library and an ORM to connect and interact with a Mongo Database.", GithubUri = "https://github.com/MonkeyDDeveloper/dockerized-flask-api-mongodb" },
                new Project { Id = 3, Name = "Api Gateway - Lambda Functions Rest Api", Description = "AWS Lambda funtions as microservices built with TypeScript to create a rest api.", GithubUri = "https://github.com/MonkeyDDeveloper/aws-lambda-apigateway-functions" },
                new Project { Id = 4, Name = "Dockerized Portfolio - .Net - Postgres", Description = "The page you are watching, it was built using nextjs, typescript, .net and postgres as database. Also, it is deployed automatically using github actions in a digital ocean droplet.", GithubUri = "https://github.com/MonkeyDDeveloper/workflows" },
                new Project { Id = 5, Name = "TypeScript Api", Description = "Dockerized TypeScript Api that uses Redis db to caching data. It implements Swagger Docs, and Jest for testing.", GithubUri = "https://github.com/MonkeyDDeveloper/api-ts-swagger" },
                new Project { Id = 6, Name = "Python CLI CRUD with Postgres", Description = "CRUD with Python using Psycopg2, Docker, Postgres SQL Scripts, Bcrypt, PrettyTable and email-validator", GithubUri = "https://github.com/MonkeyDDeveloper/python_console_crud" }
            );

            builder.Entity<TechnologieProject>().HasData(
                new TechnologieProject() { Id = 1, ProjectId = 1, TechnologieId = 1},
                new TechnologieProject() { Id = 2, ProjectId = 1, TechnologieId = 2},
                new TechnologieProject() { Id = 3, ProjectId = 1, TechnologieId = 6},
                new TechnologieProject() { Id = 4, ProjectId = 1, TechnologieId = 11},
                new TechnologieProject() { Id = 5, ProjectId = 1, TechnologieId = 12 },
                new TechnologieProject() { Id = 6, ProjectId = 1, TechnologieId = 33 },
                new TechnologieProject() { Id = 7, ProjectId = 1, TechnologieId = 34 },
                new TechnologieProject() { Id = 8, ProjectId = 1, TechnologieId = 28 },
                new TechnologieProject() { Id = 9, ProjectId = 1, TechnologieId = 38 },
                new TechnologieProject() { Id = 10, ProjectId = 2, TechnologieId = 12 },
                new TechnologieProject() { Id = 11, ProjectId = 2, TechnologieId = 39 },
                new TechnologieProject() { Id = 12, ProjectId = 2, TechnologieId = 40 },
                new TechnologieProject() { Id = 13, ProjectId = 2, TechnologieId = 41 },
                new TechnologieProject() { Id = 14, ProjectId = 3, TechnologieId = 42 },
                new TechnologieProject() { Id = 15, ProjectId = 3, TechnologieId = 43 },
                new TechnologieProject() { Id = 16, ProjectId = 3, TechnologieId = 44 },
                new TechnologieProject() { Id = 17, ProjectId = 3, TechnologieId = 28 },
                new TechnologieProject() { Id = 18, ProjectId = 4, TechnologieId =  45 },
                new TechnologieProject() { Id = 19, ProjectId = 4, TechnologieId =  46 },
                new TechnologieProject() { Id = 20, ProjectId = 4, TechnologieId =  47 },
                new TechnologieProject() { Id = 21, ProjectId = 4, TechnologieId =  48 },
                new TechnologieProject() { Id = 22, ProjectId = 4, TechnologieId =  49 },
                new TechnologieProject() { Id = 23, ProjectId = 4, TechnologieId =  50 },
                new TechnologieProject() { Id = 24, ProjectId = 4, TechnologieId =  28 },
                new TechnologieProject() { Id = 25, ProjectId = 4, TechnologieId =  12 },
                new TechnologieProject() { Id = 26, ProjectId = 4, TechnologieId =  23 },
                new TechnologieProject() { Id = 27, ProjectId = 5, TechnologieId =  51 },
                new TechnologieProject() { Id = 28, ProjectId = 5, TechnologieId =  52 },
                new TechnologieProject() { Id = 29, ProjectId = 5, TechnologieId =  53 },
                new TechnologieProject() { Id = 30, ProjectId = 5, TechnologieId =  54 },
                new TechnologieProject() { Id = 31, ProjectId = 5, TechnologieId =  49 },
                new TechnologieProject() { Id = 32, ProjectId = 5, TechnologieId =  23 },
                new TechnologieProject() { Id = 33, ProjectId = 5, TechnologieId =  12 },
                new TechnologieProject() { Id = 34, ProjectId = 5, TechnologieId =  9 },
                new TechnologieProject() { Id = 35, ProjectId = 6, TechnologieId =  46 },
                new TechnologieProject() { Id = 36, ProjectId = 6, TechnologieId =  39 },
                new TechnologieProject() { Id = 37, ProjectId = 6, TechnologieId =  23 },
                new TechnologieProject() { Id = 38, ProjectId = 6, TechnologieId =  12 }
            );

        }

    }
}
