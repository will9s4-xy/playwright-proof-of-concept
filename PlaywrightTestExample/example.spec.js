// @ts-check
import { test, expect } from '@playwright/test';

test("search for palm Treo Pro", async ({ page }) => {
  await page.goto('https://ecommerce-playground.lambdatest.io/');

  await page.locator("span.title", { hasText: 'Mega Menu' }).hover();
  await page.locator("a[title=Desktop]").click();

  // Hover over product to ensure buttons are active
  const product = page.locator(".product-layout", { hasText: 'Palm Treo Pro' });
  await product.hover();
  
  // Click Add to Cart
  await product.locator("button[title='Add to Cart']").click({ force: true });

  // Wait for the 'View Cart' button to appear in the success toast and click it
  // Using getByRole is more robust for buttons/links
  await page.locator('.cart-icon').first().click();

  // FIX: Match the exact casing 'Palm Treo Pro' or use a regex /palm treo pro/i
  await expect(page.locator("td.text-left", { hasText: 'Palm Treo Pro' })).toBeVisible();
  
  // Verify quantity
  await expect(page.locator("#content input[value='1']")).toBeVisible();
});