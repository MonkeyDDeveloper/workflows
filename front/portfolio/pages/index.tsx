import { useTranslations } from "next-intl"
import { motion } from "framer-motion";
import { Button, ButtonGroup } from "@nextui-org/react";
import { useState } from "react";
import { Tooltip } from "@nextui-org/react";
import WhatsApp from "@/components/icons/Whatsapp";
import RightArrow from "@/components/icons/ArrowRight";

export default function Index() {
    const t = useTranslations()
    const [buttonColor, setButtonColor] = useState<"primary" | "danger" | "warning">("primary")
    const [buttonHovered, setButtonHovered] = useState(false)
    return (
        <section className="w-11/12 mx-auto">
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }}>
                <p className="mb-4 text-center text-orange-600 dark:text-orange-400 font-minecraft text-4xl font-bold">{t('index.bigHi')}</p>
            </motion.section>
            <motion.section className="mb-4" initial={{ opacity: 0 }} whileInView={{ opacity: 600 }} transition={{ delay: 0.5 }}>
                <p className="mb-2 text-center font-minecraft text-xs  text-orange-600 dark:text-cyan-200 font-bold">{t('index.myNameIs')}</p>
            </motion.section>
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ delay: 1 }}>
                <motion.p
                    className="mb-4 text-center"
                >
                    <Tooltip
                        classNames={{
                            content: [
                                "font-minecraft"
                            ]
                        }}
                        content={t("index.linkedinMessage")}
                        placement="right"
                        offset={15}
                    >
                        <motion.a
                            href="https://www.linkedin.com/in/javier-fray/"
                            target="_blank"
                            className="font-minecraft text-7xl text-cyan-600 font-bold hover:underline hover:underline-offset-8 inline-block"
                            whileHover={{ x: [-10, 10, 0] }}
                            transition={{ duration: .1 }}
                        >
                            {t('index.title')}
                        </motion.a>
                    </Tooltip>
                </motion.p>
            </motion.section>
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ delay: 1.5, duration: 2 }}>
                <p className="mb-2 text-center font-minecraft text-xs text-orange-600 dark:text-cyan-200 font-bold">{t('index.and')}</p>
            </motion.section>
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ delay: 2, duration: 2 }}>
                <p className="mb-8 text-center font-minecraft text-6xl text-cyan-600 font-bold">{t('index.beWelcomeTo')}</p>
            </motion.section>
            <motion.section className="flex justify-center"
                initial={{ opacity: 0 }}
                whileInView={{ opacity: 1 }}
                transition={{ delay: 2.5, duration: 2 }}
            >
                <motion.div
                    initial={{ borderRadius: 40, boxShadow: "none" }}
                    whileHover={{
                        boxShadow: [
                            "0px 0px 10px rgba(255, 0, 0, 0.5)",
                            "0px 0px 40px rgba(255, 100, 0, 0.5)",
                            "0px 0px 10px rgba(255, 0, 0, 0.5)",
                            "0px 0px 40px rgba(255, 100, 0, 0.5)",
                            "0px 0px 80px rgba(255, 0, 0, 0.5)",
                        ],
                    }}
                    transition={{ duration: 2 }}
                    onHoverStart={() => {
                        setButtonHovered(true)
                        setButtonColor("warning")
                    }}
                    onHoverEnd={() => {
                        setButtonHovered(false)
                        setButtonColor("primary")
                    }}
                >
                    <Button size="lg" color={buttonColor}>
                        <span className="font-minecraft">
                            {
                                buttonHovered
                                    ? t('index.secondaryPortfolioButton')
                                    : t('index.myPortfolioButton')
                            }
                        </span>
                        <RightArrow className={buttonHovered ? 'text-black' : 'text-white'} />
                    </Button>
                </motion.div>
            </motion.section>
            <motion.section
                className="mt-6 flex flex-wrap justify-center text-[#00bb2d] hover:cursor-pointer"
                whileInView={{
                    y: [0, -10, 0],
                }}
                transition={{ duration: 2, repeat: Infinity }}
            >
                <Tooltip
                    classNames={{
                        content: [
                            "font-minecraft"
                        ]
                    }}
                    content={t("index.tooltipMessage")}
                    placement="bottom"
                    offset={15}
                >
                    <a href="https://wa.me/593988433654" target="_blank">
                        <WhatsApp width={36} height={36} />
                    </a>
                </Tooltip>
            </motion.section>
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