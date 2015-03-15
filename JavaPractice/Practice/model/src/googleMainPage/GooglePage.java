package googleMainPage;

import basePage.BasePage;
import org.junit.Assert;
import org.openqa.selenium.WebDriver;

public class GooglePage extends BasePage {
    private static final String baseUrl = "http://www.google.com/webhp?hl=en";
    private static final String expectedTitle = "Google";
    private GoogleMap map;

    public GooglePage(WebDriver driver) {
        super(new GoogleMap(driver), driver);
        this.map = (GoogleMap) super.getMap();
    }

    public void navigate() {
        this.getDriver().navigate().to(baseUrl);
    }

    public void openMenu() {
        this.map.menuButton().click();
    }

    @Override
    public void correctPageLoaded() {
        String actualTitle = this.getMap().pageTitle();
        Assert.assertEquals(actualTitle, expectedTitle);
    }
}
