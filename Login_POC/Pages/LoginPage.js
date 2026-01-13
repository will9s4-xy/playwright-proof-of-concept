const {BasePage} = require('./BasePage');

class LoginPage extends BasePage {
    constructor(page) {
        super(page)

        this.usernameInput = '#user-name';
        this.passwordInput = '#password';
        this.loginbtn = '#login-button';
 

    }
    async open(){
        await this.goto();
    }
    async login(user, pass){

        if (typeof user !== 'string' || typeof pass !== 'string'){
            throw new Error ('Login called with invalid args: user= ${user}, pass= ${pass} ');
        }
        await this.page.fill(this.usernameInput, user);
        await this.page.fill(this.passwordInput, pass);
        await this.page.click(this.loginbtn);
    }
}
module.exports = {LoginPage};