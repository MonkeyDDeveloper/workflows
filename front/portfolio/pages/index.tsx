import { useTranslations } from "next-intl"
import { motion } from "framer-motion";
import { Button, ButtonGroup } from "@nextui-org/react";
import { useState } from "react";
import HeadPhones from "@/components/icons/HeadPhones"
import ClickHand from "@/components/icons/ClickHand"

export default function Index() {
    const t = useTranslations()
    const [buttonColor, setButtonColor] = useState<"primary" | "danger" | "warning">("primary")
    const [buttonHovered, setButtonHovered] = useState(false)
    return (
        <section className="w-11/12 mx-auto">
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }}>
                <p className="mb-2 text-center text-7xl text-cyan-200 font-bold">{t('index.bigHi')}</p>
            </motion.section>
            <motion.section className="mb-4" initial={{ opacity: 0 }} whileInView={{ opacity: 600 }} transition={{ delay: 0.5 }}>
                <p className="mb-2 text-center text-xs text-cyan-200 font-bold">{t('index.myNameIs')}</p>
            </motion.section>
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ delay: 1 }}>
                <p className="mb-2 text-center font-minecraft text-7xl text-cyan-600 font-bold">{t('index.title')}</p>
            </motion.section>
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ delay: 1.5, duration: 2 }}>
                <p className="mb-2 text-center font-minecraft text-xs text-cyan-200 font-bold">{t('index.and')}</p>
            </motion.section>
            <motion.section initial={{ opacity: 0 }} whileInView={{ opacity: 1 }} transition={{ delay: 2.5, duration: 3 }}>
                <p className="mb-8 text-center font-minecraft text-6xl text-cyan-600 font-bold">{t('index.beWelcomeTo')}</p>
            </motion.section>
            <motion.section className="flex justify-center"
                initial={{ opacity: 0 }}
                whileInView={{ opacity: 1 }}
                transition={{ delay: 3.5, duration: 3 }}
            >
                <motion.section
                    whileHover={{
                        x: [0, 1, -1, 0],
                    }}
                    transition={{ duration: 0.2, repeat: Infinity }}
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
                        whileInView={{
                            y: [0, -10, 0],
                        }}
                        transition={{ duration: 2, repeat: Infinity }}
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
                            <HeadPhones />
                            {
                                buttonHovered
                                    ? <ClickHand />
                                    : null
                            }
                        </Button>
                    </motion.div>
                </motion.section>
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