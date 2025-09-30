/**
 *  @Type (import('@playwright/Test').PlaywrightTestConfig)
*/ 
const config= {
    TestDir:  './Tests',
    Testmatch: ['**/*.spec.js', '**/*.test.js' ], 
    Timeout: 30 * 1000,
    retries: 2,

    reporter: [
        ['list'],
        ['html', {open:'never'}]
    ], 
    use: {
        headless: false,
        veiwport: {width: 1280, height: 720},
        Video: 'retain-on-failure',      
        baseURL: 'https://www.saucedemo.com/'
    },
}
module.exports = config;