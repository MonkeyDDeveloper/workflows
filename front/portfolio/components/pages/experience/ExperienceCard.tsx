import { ProfessionalExperience } from "@/models/ProfessionalExperience";
import { Card, CardHeader, CardBody } from "@nextui-org/react";
import { useTranslations } from "next-intl";
import { motion } from "framer-motion";
import TechnologieIcon from "./TechnologieIcon";
import { Tooltip } from "@nextui-org/react";

export default function ExperienceCard({ experience, className = "" }: { experience: ProfessionalExperience, className?: string }) {
    const t = useTranslations()

    return (
        <motion.div
            initial={{ x: -10, opacity: 0 }}
            whileInView={{ x: 0, opacity: 1 }}
            transition={{
                type: "spring",
                duration: 1
            }}
            className={className}
        >
            <Card className="py-4 shadow-lg shadow-cyan-900 dark:shadow-black">
                <CardHeader className="pb-0 pt-2 px-4 flex-col items-start">
                    <h4 className="text-large uppercase font-bold mb-1 font-minecraft text-cyan-900 dark:text-white">{experience.title}</h4>
                    <section className="mb-2 flex flex-wrap justify-start text-cyan-600 text-md">
                        {
                            Array.from(new Map(experience.technologieExperiences.map(technologieExp => [technologieExp.technologie.abbr, technologieExp.technologie.name])))
                                .map((technologieAbbr, index) => {
                                    return (
                                        <motion.section
                                            initial={{ x: -1, opacity: 0 }}
                                            animate={{ x: 0, opacity: 1 }}
                                            transition={{ delay: 1 + index / 5 }}
                                            className="p-0.5"
                                        >
                                            <Tooltip
                                                classNames={{
                                                    content: [
                                                        "font-minecraft",
                                                        "dark:text-orange-700",
                                                        "text-cyan-900"
                                                    ]
                                                }}
                                                content={technologieAbbr[1]}
                                                placement="bottom"
                                                offset={15}
                                            >
                                                <section>
                                                    <TechnologieIcon className="hover:cursor-pointer hover:scale-[1.75] hover:bg-cyan-950 hover:rounded-sm hover:text-cyan-300 hover:drop-shadow-md hover:shadow-cyan-600" technologieAbbr={technologieAbbr[0]} />
                                                </section>
                                            </Tooltip>
                                        </motion.section>
                                    )
                                })
                        }
                    </section>
                    <p className="mb-2 font-bold text-tiny">{experience.startDate} - {experience.isCurrent ? t("experience.present") : experience.endDate}</p>
                    <small className="text-black dark:text-default-500">{experience.description}</small>
                </CardHeader>
                <CardBody className="overflow-visible py-2">
                    body here
                </CardBody>
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