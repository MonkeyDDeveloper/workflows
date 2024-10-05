"use client"

import Link from "next/link"
import { cn } from "../../lib/utils/cn"
import { useTranslations } from "next-intl"
import { useRouter } from "next/router"
import LanguageSwitcher from "./LaguageSwitcher"
import DarkModeToggle from "./DarkModeToggle"

export default function Navigation() {
    const t = useTranslations()
    // const cookieStore = useCookies()
    const router = useRouter()
    const pathname = router.pathname

    const navItems = [
        { name: t("navigation.index"), path: `/` },
        { name: t("navigation.experience"), path: `/portfolio/experience` },
        { name: t("navigation.projects"), path: `/portfolio/projects` },
    ]

    return (
        <section className="mt-2 grid grid-cols-3 grid-rows-1 gap-4">
            <section>

            </section>
            <nav className="flex justify-center items-center h-16 bg-background/95 backdrop-blur supports-[backdrop-filter]:bg-background/60 z-50 sticky top-0">
                <ul className="flex space-x-4">
                    {navItems.map((item) => (
                        <li key={item.path}>
                            <Link
                                href={item.path}
                                className={cn(
                                    "relative px-3 py-2 transition-colors hover:text-cyan-600 hover:underline hover:underline-offset-4",
                                    pathname === item.path ? "text-cyan-600 underline underline-offset-4" : "text-foreground/60"
                                )}
                            >
                                <span className="text-lg">
                                    {item.name}
                                </span>
                            </Link>
                        </li>
                    ))}
                </ul>
            </nav>
            <section className="flex items-center justify-end">
                <section className="mr-4">
                    <LanguageSwitcher />
                </section>
                <section>
                    <DarkModeToggle />
                </section>
            </section>
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