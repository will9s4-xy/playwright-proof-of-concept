const { test, expect } = require("@playwright/test");

test("LambdaTest Playground - Sum Calculation", async ({ page }) => {
  // Use 'domcontentloaded' to avoid waiting for endless background scripts
  await page.goto("https://www.lambdatest.com/selenium-playground/simple-form-demo", { 
    waitUntil: "domcontentloaded" 
  });

  // Wait for specific element instead of the whole network
  await page.waitForSelector("#sum1", { state: "visible" });

  await page.waitForTimeout(500); // Short pause
  await page.locator("#sum1").fill("1");


  await page.locator("#sum2").fill("4");
  await page.waitForTimeout(500);

  await page.getByRole("button", { name: "Get Sum" }).click();

  // Assert result
  await expect(page.locator("#addmessage")).toHaveText("5");
});


test("LambdaTest Playground Example", async ({ page }) => {
  await page.goto("https://www.lambdatest.com/selenium-playground/simple-form-demo");
  
  await page.waitForTimeout(500); 
  await page.locator("#sum1").fill("1");
  await page.locator("#sum2").fill("2");
  await page.getByRole("button", { name: "Get Sum" }).click();
  
  // Use a regex /3/ to match the number within the result text
  await expect(page.locator("#addmessage")).toHaveText(/3/);
});