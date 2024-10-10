import { useEffect } from "react"
import { portofioApi } from "../../../services/portfolio.services"
import { ProfessionalExperience } from "../../../models/ProfessionalExperience"
import { useTranslations } from "next-intl"

async function getExperiences() {
    const uri = `${process.env.NEXT_PUBLIC_BACK_API_URI}/professional-experiences`
    console.log({ uri })
    const { message, data } = await portofioApi.get<ProfessionalExperience>(uri)
    console.log({ message, data })
}

export default function Index() {

    const t = useTranslations()

    useEffect(() => {
        getExperiences()
    }, [])

    return (
        <section>
            test auto deploy
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