import { useRouter } from "next/router";

export default function LanguageSwitcher() {
    const router = useRouter();

    function handleChange(locale: string) {
        router.push(router.asPath, router.asPath, { locale });
    }

    return (
        <section className="language-switcher">
            <select name="language" id="language" onChange={(e) => handleChange(e.target.value)}>
                <option value="en">EN</option>
                <option value="es">ES</option>
            </select>
        </section>
    )
}
