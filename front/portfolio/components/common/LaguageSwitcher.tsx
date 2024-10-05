import { useRouter } from "next/router";
import { useState } from "react";

export default function LanguageSwitcher() {
    const router = useRouter();
    const [languageSelected, setLanguageSelected] = useState(router.locale)

    function handleChange(locale: string) {
        router.push(router.asPath, router.asPath, { locale });
    }

    return (
        <section className="language-switcher">
            <select name="language" value={languageSelected} onChange={(e) => handleChange(e.target.value)}>
                <option value="en">EN</option>
                <option value="es">ES</option>
            </select>
        </section>
    )
}
