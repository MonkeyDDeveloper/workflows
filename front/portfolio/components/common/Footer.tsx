import { BsLinkedin } from "react-icons/bs"
import { BsGithub } from "react-icons/bs"
import { BsWhatsapp } from "react-icons/bs"
import { FaFileAlt } from "react-icons/fa"
import { motion } from "framer-motion"

export default function Footer() {    
    return (
        <div className="p-2 pb-4 border-t border-cyan-600 bg-transparent">
            <p className="text-lg text-center mb-3 font-minecraft">Javier Fray</p>
            <section className="flex flex-wrap justify-center">
                <a href="https://wa.me/593988433654" target="_blank">
                    <BsWhatsapp className="mx-1 w-6 h-6" />
                </a>
                <a href="https://github.com/MonkeyDDeveloper" target="_blank">
                    <BsGithub className="mx-1 w-6 h-6" />
                </a>
                <a href="https://www.linkedin.com/in/javier-fray/" target="_blank">
                    <BsLinkedin className="mx-1 w-6 h-6" />
                </a>
                <a href="https://bit.ly/resume-javier-fray" target="_blank">
                    <FaFileAlt className="mx-1 w-6 h-6" />
                </a>
            </section>
            <p className="text-sm text-center mt-3 font-minecraft">© 2024 <span className="block text-center m-0 opacity-0 hover:opacity-100 hover:cursor-pointer">Mayra <motion.span className="inline-block m-0" whileInView={{ scale: [1, 1.2, 1], transition: { duration: 1.1, repeat: Infinity } }}>❤️</motion.span></span></p>
        </div>
    )
}
