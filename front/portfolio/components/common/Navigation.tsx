"use client"

import Link from "next/link"
import { useTranslations } from "next-intl"
import { useRouter } from "next/router"
import LanguageSwitcher from "./LaguageSwitcher"
import DarkModeToggle from "./DarkModeToggle"
import WhatsApp from "../icons/Whatsapp"
import { Navbar, NavbarBrand, NavbarContent, NavbarItem, NavbarMenuToggle, NavbarMenu, NavbarMenuItem, Button } from "@nextui-org/react";
import { useEffect, useState } from "react"
import { Tooltip } from "@nextui-org/react"


export default function Navigation() {
    const t = useTranslations()
    const router = useRouter()
    const pathname = router.pathname
    const [isMenuOpen, setIsMenuOpen] = useState(false)

    const navItems = [
        { name: t("navigation.index"), path: `/` },
        { name: t("navigation.experience"), path: `/portfolio/experience` },
        { name: t("navigation.projects"), path: `/portfolio/projects` },
        { name: t("navigation.about"), path: `/portfolio/about` },
    ]

    useEffect(() => {
        console.log({ pathname })
        setIsMenuOpen(false)
    }, [pathname])

    return (
        <Navbar isMenuOpen={isMenuOpen} onMenuOpenChange={setIsMenuOpen} className="bg-transparent">
            <NavbarContent>
                <NavbarMenuToggle
                    aria-label={isMenuOpen ? "Close menu" : "Open menu"}
                    className="sm:hidden"
                />
                <NavbarBrand>
                    <Tooltip
                        content={t('navigation.watchMyCv')}
                        classNames={{ content: ["font-minecraft"] }}
                    >
                        <span className="font-minecraft text-cyan-600 text-xl">
                            <a href="https://bit.ly/javier-fray-resume" target="_blank">MonkeyDeveloper</a>
                        </span>
                    </Tooltip>
                </NavbarBrand>
            </NavbarContent>

            <NavbarContent className="hidden sm:flex gap-4" justify="center">
                {navItems.map((item, index) => {
                    return (
                        <NavbarItem key={`${item}-${index}`}>
                            <Link href={item.path}>
                                <span className={`font-minecraft ${item.path == pathname ? 'text-cyan-600' : 'text-foreground'}`}>
                                    {item.name}
                                </span>
                            </Link>
                        </NavbarItem>
                    )
                })}
            </NavbarContent>
            <NavbarContent className="hidden sm:flex gap-4" justify="end">
                <NavbarItem>
                    <LanguageSwitcher />
                </NavbarItem>
                <NavbarItem>
                    <DarkModeToggle />
                </NavbarItem>
            </NavbarContent>
            <NavbarMenu>
                {navItems.map((item, index) => (
                    <NavbarMenuItem key={`${item}-${index}`}>
                        <Link href={item.path}>
                            <span className={`font-minecraft w-full ${item.path == pathname ? 'text-cyan-600' : 'text-foreground'}`}>
                                {item.name}
                            </span>
                        </Link>
                    </NavbarMenuItem>
                ))}
                <NavbarItem className="mt-4">
                    <a className="text-[#00bb2d]" href="https://wa.me/593988433654" target="_blank">
                        <WhatsApp width={36} height={36} />
                    </a>
                </NavbarItem>
                <NavbarItem className="mt-4">
                    <LanguageSwitcher />
                </NavbarItem>
                <NavbarItem className="flex justify-end">
                    <DarkModeToggle />
                </NavbarItem>
            </NavbarMenu>
        </Navbar>
    )
}

export async function getStaticProps(context) {
    return {
        props: {
            messages: (await import(`@/public/locales/${context.locale}.json`)).default
        }
    };
}