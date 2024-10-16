import { Project } from "@/models/Project";
import { motion } from "framer-motion";
import { Card, CardBody, CardHeader } from "@nextui-org/card";
import { Image } from "@nextui-org/react";
import TechnologiesGrid from "./ProjectCardTechnologiesGrid";
import { useTranslations } from "next-intl";
import TechnologieIcon from "@/components/common/TechnologieIcon";

export default function ProjectCard({ project, className = "" }: { project: Project, className: string }) {
    const t = useTranslations();
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
            <Card className="py-4 shadow-sm shadow-cyan-900 hover:shadow-cyan-900 dark:shadow-black hover:shadow-lg dark:hover:shadow-sm dark:hover:shadow-white">
                <motion.section
                    className="md:grid md:grid-cols-2"
                >
                    <CardHeader className="pb-0 pt-2 px-4 flex-col items-start">
                        <h4 className="text-large uppercase font-bold mb-1 font-minecraft text-cyan-900 dark:text-white">
                            {project.name}
                        </h4>
                        <p className="text-sm text-black dark:text-default-500">{project.description}</p>
                    </CardHeader>
                    <CardBody className="overflow-visible py-2 mt-1">
                        <TechnologiesGrid technologies={project.projectTechnologies.map(projectTechnologie => projectTechnologie.technologie)} />
                        <p className="mt-4 text-end text-sm text-black dark:text-default-500">
                            <a href={project.githubUri} target="_blank" className="hover:underline underline-offset-8 dark:text-white font-minecraft">
                                <TechnologieIcon className="inline-block w-6 h-6" technologieAbbr="github" /> {t("projects.repositoryMessage")}
                            </a>
                        </p>
                    </CardBody>
                </motion.section>
            </Card>
        </motion.div>
    )
}

export async function getStaticProps(context) {
    return {
        props: {
            messages: (await import(`@/public/locales/${context.locale}.json`)).default
        }
    };
}