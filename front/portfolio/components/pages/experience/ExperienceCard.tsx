import { ProfessionalExperience } from "@/models/ProfessionalExperience";
import { Card, CardHeader, CardBody } from "@nextui-org/react";
import { useTranslations } from "next-intl";
import { motion } from "framer-motion";
import ExperienceCardAccordion from "./ExperienceCardAccordion"
import TechnologieIconList from "./TechnologieIconsList";
import { Technologie } from "@/models/Technologie";
import { TechnologieExperience } from "@/models/TechnologieExperience";
import { Image } from "@nextui-org/react";

export default function ExperienceCard({ experience, className = "" }: { experience: ProfessionalExperience, className?: string }) {
    const t = useTranslations()
    const getTechnologies = (technologieExperiences: TechnologieExperience[]): Technologie[] => {
        return technologieExperiences.map(te => te.technologie)
    }
    console.log({ experience })

    return (
        <motion.div
            initial={{ x: -10, opacity: 0 }}
            whileInView={{ x: 0, opacity: 1 }}
            whileHover={{ scale: 1.020, transition: { delay: 0 } }}
            transition={{
                type: "spring",
                duration: 1
            }}
            className={className}
        >
            <Card className="py-4 shadow-sm shadow-cyan-900 hover:shadow-cyan-900 dark:shadow-black hover:shadow-lg dark:hover:shadow-white">
                <motion.section
                    className="md:grid md:grid-cols-2"
                >
                    <CardHeader className="pb-0 pt-2 px-4 flex-col items-start">
                        <h4 className="text-large uppercase font-bold mb-1 font-minecraft text-cyan-900 dark:text-white">
                            <section className="md:hidden mr-3 w-2/12 inline-block">
                                <Image className="rounded-full" src={experience.companyExperience.company.logoPath} isBlurred />
                            </section>
                            {experience.title}
                        </h4>
                        <section className="mb-2 flex flex-wrap justify-start text-cyan-600 text-md">
                            <TechnologieIconList experience={experience} />
                        </section>
                        <p className="mb-2 font-bold text-tiny">{experience.startDate} - {experience.isCurrent ? t("experience.present") : experience.endDate}</p>
                        <p className="text-sm text-black dark:text-default-500">{experience.description}</p>
                        <section className="hidden flex-grow w-full md:flex flex-wrap justify-center items-center">
                            <section className="w-1/2">
                                {
                                    experience.companyExperience.company.logoPath
                                        ? <Image src={experience.companyExperience.company.logoPath} isBlurred />
                                        : null
                                }
                            </section>
                        </section>
                    </CardHeader>
                    <CardBody className="overflow-visible py-2">
                        <ExperienceCardAccordion responsibilites={experience.responsabilities} technologies={getTechnologies(experience.technologieExperiences)} />
                    </CardBody>
                </motion.section>
            </Card>
        </motion.div>
    );
}

export async function getStaticProps(context) {
    return {
        props: {
            messages: (await import(`@/public/locales/${context.locale}.json`)).default
        }
    };
}