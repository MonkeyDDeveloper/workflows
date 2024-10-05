import { ThemeProvider } from "next-themes"
import Navigation from "../components/common/Navigation"
export default function Layout({ children }) {
    return (
        <ThemeProvider attribute="class" defaultTheme="system" enableSystem>
            <section className="w-12/12 md:w-8/12 mx-auto">
                <Navigation />
                <main>
                    {children}
                </main>
            </section>
        </ThemeProvider>
    )
}