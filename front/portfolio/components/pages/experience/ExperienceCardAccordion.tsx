import { Responsabilitie } from "@/models/Responsabilitie";
import { Accordion, AccordionItem } from "@nextui-org/react";
import { useTranslations } from "next-intl"
import { motion } from "framer-motion";

export default function ExperienceCardAccordion({ responsibilites = [] }: { responsibilites: Responsabilitie[] }) {
    const t = useTranslations()
    const defaultContent =
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.";

    return (
        <Accordion isCompact>
            <AccordionItem key="1" aria-label={t("experience.accordion.responsibilities")} title={t("experience.accordion.responsibilities")}>
                <ul className="list-disc">
                    {responsibilites.map((responsability, index) => (
                        <motion.li
                            key={index}
                            initial={{ x: 10 }}
                            animate={{ x: 0 }}
                            transition={{ delay: 0 + index / 5 }}
                            className="text-xs text-cyan-600"
                        >
                            {responsability.description}
                        </motion.li>
                    ))}
                </ul>
            </AccordionItem>
            <AccordionItem key="2" aria-label={t("experience.accordion.technologies")} title={t("experience.accordion.technologies")}>
                {defaultContent}
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