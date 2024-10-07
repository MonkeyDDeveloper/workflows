module.exports = {
    reactStrictMode: true,
    i18n: {
        locales: ['es', 'en'],
        defaultLocale: 'en',
    },
    compiler: {
        styledComponents: true,
    },
    env: {
        NEXT_PUBLIC_BACK_API_URI: process.env.NEXT_PUBLIC_BACK_API_URI
    }
};