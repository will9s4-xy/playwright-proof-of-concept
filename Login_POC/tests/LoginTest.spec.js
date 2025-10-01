import {test, expect} from '@playwright/test';
import {LoginPage}  from '../Pages/LoginPage';
import {users, messages}  from '../data/testdata';

test("bad username", async ({page}) => {
const badUsername = new LoginPage(page);


await badUsername.open();
await badUsername.login(users.invalid.username , users.valid.password);

const errorText = page.locator('[data-test = "error"]') ;

await expect(errorText).toBeVisible();
await expect(errorText).toHaveText(messages.invalidcred);

}); 

test("bad password", async ({page}) => {
const badUsername = new LoginPage(page);


await badUsername.open();
await badUsername.login(users.valid.username , users.invalid.password);

const errorText = page.locator('[data-test = "error"]') ;

await expect(errorText).toBeVisible();
await expect(errorText).toHaveText(messages.invalidcred);

}); 

test("invalid login", async ({page}) => {
const badUsername = new LoginPage(page);


await badUsername.open();
await badUsername.login(users.invalid.username , users.invalid.password);

const errorText = page.locator('[data-test = "error"]') ;

await expect(errorText).toBeVisible();
await expect(errorText).toHaveText(messages.invalidcred);

}); 

test('login successfully', async ({page}) => {
    const login = new LoginPage(page);
    
    await login.open()
    await login.login( users.valid.username, users.valid.password);
    
    await expect(page).toHaveURL(/.*inventory/);
    await expect(page.locator('.inventory_list')).toBeVisible();
});