const {BasePage} = require('./BasePage');

class LoginPage extends BasePage {
    constructor(page) {
        super(page)

        this.usernameInput = '#user-name';
        this.passwordInput = '#password';
        this.loginbtn = '#login-button';
        this.errorText = '[data-test = "error"]';
    }
    async open(){
        await this.goto();
    }

    async login(username, password){
        await this.page.fill(this.usernameInput, username);
        await this.page.fill(this.passwordInput, password);
        await this.page.click(this.loginbtn);
    }
    async getErrorMessage(){
        return await this.page.textContent(this.errorText);
    }
}
module.exports = {LoginPage};