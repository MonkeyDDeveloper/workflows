import TechnologieIcon from "@/components/common/TechnologieIcon"
import { Technologie } from "@/models/Technologie"
import { Tooltip } from "@nextui-org/react"
import { motion } from "framer-motion"

export default function TechnologieIconList({ technologies }: { technologies: Technologie[] }) {
    return (
        <section className="grid grid-cols-4 gap-1 place-items-center">
            {
                technologies
                    .map((technologie, index) => {
                        return (
                            <motion.section
                                initial={{ x: -1, opacity: 0 }}
                                animate={{ x: 0, opacity: 1, rotate: 720 }}
                                transition={{ delay: 1 + index / 2 }}
                                className="p-0.5"
                                key={index}
                            >
                                <Tooltip
                                    classNames={{
                                        content: [
                                            "font-minecraft",
                                            "dark:text-orange-700",
                                            "text-cyan-900"
                                        ]
                                    }}
                                    content={technologie.name}
                                    placement="bottom"
                                    offset={15}
                                >
                                    <section>
                                        <TechnologieIcon className="w-14 h-14 text-cyan-600 hover:cursor-pointer hover:scale-[1.75] hover:rounded-sm hover:text-cyan-300 hover:drop-shadow-md hover:shadow-cyan-600" technologieAbbr={technologie.abbr} />
                                    </section>
                                </Tooltip>
                            </motion.section>
                        )
                    })
            }
        </section>
    )
}