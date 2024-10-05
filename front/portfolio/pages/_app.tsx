import '../styles/global.css'
import Layout from '../layouts/default';
import { useRouter } from 'next/router';
import { AppProps } from 'next/app';
import { NextIntlClientProvider } from 'next-intl';
import { NextUIProvider } from "@nextui-org/react";

const MyApp = ({ Component, pageProps }: AppProps) => {
    const router = useRouter();
    return (
        <NextIntlClientProvider
            locale={router.locale}
            timeZone="America/Guayaquil"
            messages={pageProps.messages}
        >
            <NextUIProvider>
                <Layout>
                    <Component {...pageProps} />
                </Layout>
            </NextUIProvider>
        </NextIntlClientProvider>
    );
};

export default MyApp;