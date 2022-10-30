const { CacheAccountType } = require('@azure/msal-common');
const { createProxyMiddleware } = require('http-proxy-middleware');
const { env } = require('process');
const { exec } = require('child_process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
    env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:51717';
    
const context = [
    "/weatherforecast",
    "/signin-oidc",
    "/signout-oidc",
    "/api",
    "/swagger",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: target,
        secure: false,
        headers: {
            Connection: 'Keep-Alive',
            CacheAccountType: CacheAccountType.InMemory
        },
    });
    if (process.env.REACT_APP_USE_MOCK_SERVER === 'true') {
        exec('npm run start:mock-server');
    }

    app.use(appProxy);
};
