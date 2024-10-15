import { useEffect, useState } from "react"
import { portofioApi } from "../../../services/portfolio.services"
import { Project } from "../../../models/Project"
import { useTranslations } from "next-intl"
import { motion } from "framer-motion"
import ProjectCard from "@/components/pages/projects/ProjectCard"

export default function Index() {

    const [projects, setProjects] = useState<Project[]>([])
    const t = useTranslations()

    async function getProjects() {
        const uri = `${process.env.NEXT_PUBLIC_BACK_API_URI}/projects`
        console.log({ uri })
        const { message, data } = await portofioApi.get<Project[]>(uri)
        if (!data) {
            console.error(`Error consultando los proyectos: ${message}`)
            return
        }
        const reversedProjects = data.reverse()
        setProjects(reversedProjects)
    }

    useEffect(() => {
        getProjects()
    }, [])

    return (
        <section className="w-11/12 mx-auto">
            <h1 className="font-minecraft text-3xl text-orange-600">
                {t('projects.title')}!
            </h1>
            <motion.p className="mt-3" initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ duration: 0.5 }}>
                <span className="font-minecraft">
                    {t('projects.description')}
                </span>
            </motion.p>
            <motion.p className="mt-3" initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ duration: 0.5 }}>
                <span className="font-minecraft">
                    {t('projects.description2')}
                </span>
            </motion.p>
            <section className="mt-3">
                <section className="grid grid-cols-1">
                    {
                        projects.map((experience, index) => {
                            return (
                                <ProjectCard className="mb-4 hover:cursor-pointer" key={index} project={experience} />
                            )
                        })
                    }
                </section>
            </section>
        </section>
    )
}

export async function getStaticProps(context) {
    return {
        props: {
            messages: (await import(`@/public/locales/${context.locale}.json`)).default
        }
    };
}