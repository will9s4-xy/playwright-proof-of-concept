const {expect} = require ('@playwright/test');
class BasePage{
    constructor(page){
        this.page = page;
    }
    async goto(){
        await this.page.goto('/');
    }
} 
module.exports = {BasePage};