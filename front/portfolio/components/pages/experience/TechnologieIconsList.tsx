import TechnologieIcon from "@/components/common/TechnologieIcon"
import { ProfessionalExperience } from "@/models/ProfessionalExperience"
import { Tooltip } from "@nextui-org/react"
import { motion } from "framer-motion"

export default function TechnologieIconList({ experience }: { experience: ProfessionalExperience }) {
    return Array.from(new Map(experience.technologieExperiences.map(technologieExp => [technologieExp.technologie.abbr, technologieExp.technologie.name])))
        .map((technologieAbbr, index) => {
            return (
                <motion.section
                    initial={{ x: -1, opacity: 0 }}
                    animate={{ x: 0, opacity: 1 }}
                    transition={{ delay: 1 + index / 15 }}
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
                        content={technologieAbbr[1]}
                        placement="bottom"
                        offset={15}
                    >
                        <motion.section
                            whileHover={{ marginLeft: 5, marginRight: 5 }}
                        >
                            <TechnologieIcon className="hover:cursor-pointer hover:scale-[1.75] hover:bg-cyan-950 hover:rounded-sm hover:text-cyan-300 hover:drop-shadow-md hover:shadow-cyan-600" technologieAbbr={technologieAbbr[0]} />
                        </motion.section>
                    </Tooltip>
                </motion.section>
            )
        })
}