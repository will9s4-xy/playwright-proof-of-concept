/**
 *  @Type (import('@playwright/Test').PlaywrightTestConfig)
*/ 
const config= {

    Timeout: 30 * 1000,
    //retries: 2,

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