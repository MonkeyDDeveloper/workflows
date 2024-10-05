import { useTranslations } from "next-intl"

export default function Index() {
    const t = useTranslations()
    return <div>{t('index.title')}</div>
}

export async function getStaticProps(context) {
    return {
        props: {
            messages: (await import(`@/public/locales/${context.locale}.json`)).default
        }
    };
}