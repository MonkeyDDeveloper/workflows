import { ThemeProvider } from "next-themes"
import Navigation from "../components/common/Navigation"
export default function Layout({ children }) {
    return (
        <ThemeProvider attribute="class" defaultTheme="system" enableSystem>
            <section className="w-12/12 md:w-8/12 mx-auto duration-300 bg-gradient-to-b dark:from-black dark:from-5% dark:to-cyan-900 dark:to-100% min-h-screen">
                <Navigation />
                <main>
                    {children}
                </main>
            </section>
        </ThemeProvider>
    )
}