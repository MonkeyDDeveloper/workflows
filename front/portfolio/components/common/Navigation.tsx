"use client"

// import Link from "next/link"
import { useTranslations } from "next-intl"
import { useRouter } from "next/router"
import LanguageSwitcher from "./LaguageSwitcher"
import DarkModeToggle from "./DarkModeToggle"
import { Navbar, NavbarBrand, NavbarContent, NavbarItem, NavbarMenuToggle, NavbarMenu, NavbarMenuItem, Button, Link } from "@nextui-org/react";
import { useState } from "react"


export default function Navigation() {
    const t = useTranslations()
    const router = useRouter()
    const pathname = router.pathname
    const [isMenuOpen, setIsMenuOpen] = useState(false)

    const navItems = [
        { name: t("navigation.index"), path: `/` },
        { name: t("navigation.experience"), path: `/portfolio/experience` },
        { name: t("navigation.projects"), path: `/portfolio/projects` },
    ]

    return (
        <Navbar onMenuOpenChange={setIsMenuOpen}>
            <NavbarContent>
                <NavbarMenuToggle
                    aria-label={isMenuOpen ? "Close menu" : "Open menu"}
                    className="sm:hidden"
                />
                <NavbarBrand>
                    <span className="font-minecraft text-cyan-600 text-xl">
                        <i>MonkeyDeveloper</i>
                    </span>
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