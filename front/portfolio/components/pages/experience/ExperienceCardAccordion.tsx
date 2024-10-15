import { Responsabilitie } from "@/models/Responsabilitie";
import { Accordion, AccordionItem } from "@nextui-org/react";
import { useTranslations } from "next-intl"
import { motion } from "framer-motion";
import { Technologie } from "@/models/Technologie";
import { Key, useEffect, useState } from "react";
import useScreenSize from "@/hooks/useScreenSize";

export default function ExperienceCardAccordion({ responsibilites = [], technologies = [] }: { responsibilites: Responsabilitie[], technologies: Technologie[] }) {
    const t = useTranslations()
    const { width, height } = useScreenSize()
    const [expandedAccordionItems, setExpandedAccordionItems] = useState<string[]>(["1"]);
    const itemClasses = {
        title: "font-minecraft text-cyan-950 dark:text-orange-600 font-bold"
    }

    useEffect(() => {
        if (width >= 768) {
            setExpandedAccordionItems(["1", "2"])
            return
        }
        setExpandedAccordionItems([])
    }, [width])

    return (
        <Accordion
            isCompact
            selectedKeys={expandedAccordionItems}
            onSelectionChange={(keys) => setExpandedAccordionItems(Array.from(keys as Set<string>))}
            itemClasses={itemClasses}
        >
            <AccordionItem key="1" aria-label={t("experience.accordion.responsibilities")} title={t("experience.accordion.responsibilities")}>
                <ul className="list-disc md:p-1">
                    {responsibilites.map((responsability, index) => (
                        <motion.li
                            key={index}
                            initial={{ x: 10 }}
                            animate={{ x: 0 }}
                            whileHover={{ scale: 1.01, transition: { delay: 0 } }}
                            transition={{ delay: 0 + index / 15 }}
                            className="text-xs md:text-sm hover:text-orange-600 hover:cursor-pointer text-black dark:text-slate-100 md:text-black md:dark:text-slate-100"
                        >
                            {responsability.description}
                        </motion.li>
                    ))}
                </ul>
            </AccordionItem>
            <AccordionItem key="2" aria-label={t("experience.accordion.technologies")} title={t("experience.accordion.technologies")}>
                <ul className="list-disc md:p-1 grid grid-cols-2">
                    {technologies.map((technologie, index) => (
                        <motion.li
                            key={index}
                            initial={{ x: 10 }}
                            animate={{ x: 0 }}
                            whileHover={{ scale: 1.01, transition: { delay: 0 } }}
                            transition={{ delay: 0 + index / 15 }}
                            className="text-xs md:text-sm hover:text-orange-600 hover:cursor-pointer text-black dark:text-slate-100 md:text-black md:dark:text-slate-100"
                        >
                            {technologie.name}
                        </motion.li>
                    ))}
                </ul>
            </AccordionItem>
        </Accordion>
    );
}

export async function getStaticProps(context) {
    return {
        props: {
            messages: (await import(`@/public/locales/${context.locale}.json`)).default
        }
    };
}