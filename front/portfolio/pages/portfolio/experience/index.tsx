import { useEffect } from "react"
import { portofioApi } from "../../../services/portfolio.services"
import { ProfessionalExperience } from "../../../models/ProfessionalExperience"
import { useTranslations } from "next-intl"
import { motion } from "framer-motion"
import ExperienceCard from "./components/ExperienceCard"
import { useState } from "react"

export default function Index() {

    async function getExperiences() {
        const uri = `${process.env.NEXT_PUBLIC_BACK_API_URI}/professional-experiences`
        console.log({ uri })
        const { message, data } = await portofioApi.get<ProfessionalExperience[]>(uri)
        if (!data) {
            console.error(`Error consultando las experiencias profesionales: ${message}`)
            return
        }
        const reversedData = data.reverse()
        console.log({ data })
        setExperiences(reversedData)
    }

    const [experiences, setExperiences] = useState<ProfessionalExperience[]>([])
    const t = useTranslations()

    useEffect(() => {
        getExperiences()
    }, [])

    return (
        <section className="w-11/12 mx-auto">
            <h1 className="font-minecraft text-3xl text-orange-600">
                {t('experience.title')}!
            </h1>
            <motion.p className="mt-3" initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ duration: 0.5 }}>
                <span className="font-minecraft">
                    {t('experience.description')}
                </span>
            </motion.p>
            <motion.p initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ duration: 0.5 }}>
                <span className="font-minecraft">
                    {t('experience.description2')}
                </span>
            </motion.p>
            <section className="mt-3">
                {/* grid de una columna para pantallas pequeñas y responsive para pantallas más grandes */}
                <motion.div className="grid grid-cols-1 md:grid-cols-2 gap-3">
                    {
                        experiences.map((experience, index) => {
                            return (
                                <ExperienceCard key={index} experience={experience} />
                            )
                        })
                    }
                </motion.div>
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