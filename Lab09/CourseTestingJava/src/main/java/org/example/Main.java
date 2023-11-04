package org.example;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class Main {
    public static void main(String[] args) throws InterruptedException {
        WebDriver driver = new ChromeDriver();
        driver.get("https://www.twitch.tv/");
        WebElement themeToggleButton = driver.findElement(By.xpath("//*[@id=\"root\"]/div/div[2]/nav/div/div[3]/div[3]/div/div[2]/div/div/button/button"));
        themeToggleButton.click();
        WebElement themeToggleButton1 = driver.findElement(By.xpath("//*[@id=\"YIGYhHAd6r5496LJKVAk9t7PtVyYoTUZ\"]"));
        themeToggleButton1.click();
        Thread.sleep(10000);
        driver.quit();
    }
}