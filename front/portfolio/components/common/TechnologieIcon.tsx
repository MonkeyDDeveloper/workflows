import { FaDocker, FaGit, FaGithub, FaAws, FaNodeJs, FaVuejs, FaBootstrap, FaDigitalOcean, FaPython } from "react-icons/fa";
import { SiPostgresql, SiMongodb, SiExpress, SiFlask, SiTailwindcss, SiNuxtdotjs, SiTypescript, SiJsonwebtokens, SiNextdotjs, SiQuasar, SiPug, SiNginx, SiShopify, SiZod, SiNamecheap, SiMongoose, SiGithubactions, SiDotnet, SiI18Next } from "react-icons/si";
import { BsDatabaseFillGear } from "react-icons/bs";
import { TbTemplate } from "react-icons/tb";

export default function TechnologieIcon({ technologieAbbr, className = "" }: { technologieAbbr: string, className?: string }) {
    const abbrIcons = {
        'docker': <FaDocker className={className} />,
        'git': <FaGit className={className} />,
        'githubactions': <SiGithubactions className={className} />,
        'awsgateway': <FaAws className={className} />,
        'awslambda': <FaAws className={className} />,
        'node': <FaNodeJs className={className} />,
        'vue': <FaVuejs className={className} />,
        'bootstrap': <FaBootstrap className={className} />,
        'digitalocean': <FaDigitalOcean className={className} />,
        'python': <FaPython className={className} />,
        'postgres': <SiPostgresql className={className} />,
        'mongo': <SiMongodb className={className} />,
        'express': <SiExpress className={className} />,
        'flask': <SiFlask className={className} />,
        'tailwind': <SiTailwindcss className={className} />,
        'nuxt': <SiNuxtdotjs className={className} />,
        'nuxtui': <SiNuxtdotjs className={className} />,
        'typescript': <SiTypescript className={className} />,
        'jwt': <SiJsonwebtokens className={className} />,
        'nextjs': <SiNextdotjs className={className} />,
        'quasar': <SiQuasar className={className} />,
        'pugjs': <SiPug className={className} />,
        'nginx': <SiNginx className={className} />,
        'shopify': <SiShopify className={className} />,
        'DotNET': <SiDotnet className={className} />,
        'entityframework': <BsDatabaseFillGear className={className} />,
        'zod': <SiZod className={className} />,
        'i18n': <SiI18Next className={className} />,
        'liquidtemplate': <TbTemplate className={className} />,
        'namecheap': <SiNamecheap className={className} />,
        'mongoose': <SiMongoose className={className} />,
        'pymongo': <SiMongodb className={className} />,
        'github': <FaGithub className={className} />
    };
    return abbrIcons[technologieAbbr] ? abbrIcons[technologieAbbr] : technologieAbbr
}