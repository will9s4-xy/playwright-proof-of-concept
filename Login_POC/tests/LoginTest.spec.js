const {test, expect} = require('@playwright/test');
const {LoginPage} = require('../Pages/LoginPage');


test('login successfully', async ({page}) => {
    const login = new LoginPage(page);
    
    await login.open()
    await login.login('standard_user', 'secret_sauce');
    
    await expect(page).toHaveURL(/.*inventory/)
    await expect(page.locator('.inventory_list')).toBeVisible();
});