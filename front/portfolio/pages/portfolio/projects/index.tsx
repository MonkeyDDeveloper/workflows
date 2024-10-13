import { useEffect } from "react"
import { portofioApi } from "../../../services/portfolio.services"
import { Project } from "../../../models/Project"
import { useTranslations } from "next-intl"

async function getProjects() {
    const uri = `${process.env.NEXT_PUBLIC_BACK_API_URI}/projects`
    console.log({ uri })
    const { message, data } = await portofioApi.get<Project[]>(uri)
    if (!data) {
        console.error(`Error consultando los proyectos: ${message}`)
        return
    }
    console.log({ data })
    return data
}

export default function Index() {

    const t = useTranslations()

    useEffect(() => {
        getProjects()
    }, [])

    return (
        <section>
            <h1>{t('projects.title')}</h1>
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