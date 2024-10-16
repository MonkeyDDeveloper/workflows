import { useTranslations } from "next-intl";
import WhatsApp from "@/components/icons/Whatsapp";

export default function About() {
    const t = useTranslations();

    return (
        <section className="w-11/12 mx-auto">
            <h1 className="mb-2 font-minecraft dark:text-cyan-600 text-xl">{t("about.title")}</h1>

            <h2 className="mb-2 font-minecraft dark:text-orange-600">{t("about.professionalTitle")}</h2>
            <p className="mb-1 dark:text-slate-300">{t("about.professionalDescription")}</p>
            <p className="mb-1 dark:text-slate-300">{t("about.backendExperience")}</p>
            <p className="mb-1 dark:text-slate-300">{t("about.interests")}</p>

            <h2 className="mb-2 font-minecraft dark:text-orange-600">{t("about.personalTitle")}</h2>
            <p className="mb-1 dark:text-slate-300">{t("about.personalDescription")}</p>
            <p className="mb-1 dark:text-slate-300">{t("about.hometown")}</p>
            <p className="mb-3 dark:text-slate-300">{t("about.values")}</p>

            <p className="pb-3 dark:text-slate-300">{t("about.contactMessage")}</p>
        </section>
    );
}

export async function getStaticProps(context) {
    return {
        props: {
            messages: (await import(`@/public/locales/${context.locale}.json`)).default
        }
    };
}
