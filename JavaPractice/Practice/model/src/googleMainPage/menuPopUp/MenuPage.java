package googleMainPage.menuPopUp;

import basePage.BasePage;
import org.junit.Assert;
import org.openqa.selenium.WebDriver;

public class MenuPage extends BasePage {
    private static final String expected = "false";
    private MenuMap map;

    public MenuPage(WebDriver driver) {
        super(new MenuMap(driver), driver);
        this.map = (MenuMap) super.getMap();
    }

    public void clickPlayStoreIcon() {
        this.map.googlePlayIcon().click();
    }

    @Override
    public void correctPageLoaded() {
        Assert.assertEquals(expected, this.map.menuVisible());
    }
}
