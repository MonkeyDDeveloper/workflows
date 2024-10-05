import { useEffect } from "react"
import { portofioApi } from "../../../services/portfolio.services"
import { ProfessionalExperience } from "../../../models/ProfessionalExperience"
import { useTranslations } from "next-intl"

async function getExperiences() {
    const { message, data } = await portofioApi.get<ProfessionalExperience>("http://localhost:55001/api/professional-experiences")
    console.log({ message, data })
}

export default function Index() {

    const t = useTranslations()

    useEffect(() => {
        getExperiences()
    }, [])

    return (
        <section>
            <h1>{t('experience.title')}</h1>
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