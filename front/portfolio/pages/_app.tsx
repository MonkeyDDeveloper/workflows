import '../styles/global.css'
import Layout from '../layouts/default';
import { useRouter } from 'next/router';
import { AppProps } from 'next/app';
import { NextIntlClientProvider } from 'next-intl';

const MyApp = ({ Component, pageProps }: AppProps) => {
    const router = useRouter();
    return (
        <NextIntlClientProvider
            locale={router.locale}
            timeZone="America/Guayaquil"
            messages={pageProps.messages}
        >
            <Layout>
                <Component {...pageProps} />
            </Layout>
        </NextIntlClientProvider>
    );
};

export default MyApp;