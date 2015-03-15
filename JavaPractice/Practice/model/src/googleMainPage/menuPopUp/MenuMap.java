package googleMainPage.menuPopUp;

import basePage.BaseMap;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class MenuMap extends BaseMap {

    public MenuMap(WebDriver driver) {
        super(driver);
    }

    public WebElement googlePlayIcon() {
        return new WebDriverWait(this.getDriver(), 10).until(ExpectedConditions.elementToBeClickable(
                this.getDriver().findElement(By.id("gb78"))));
    }

    public String menuVisible() {
        return this.getDriver().findElement(By.cssSelector(".gb_5b")).getAttribute("aria-hidden");
    }
}
