package googleTest;

import googleMainPage.GooglePage;
import googleMainPage.menuPopUp.MenuPage;
import googlePlayPage.GooglePlayPage;
import googlePlayPage.appPage.AppPage;
import org.junit.After;
import org.junit.Before;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;

public class GoogleTest {

    private WebDriver driver;
    private GooglePage googleMain;
    private GooglePlayPage playPage;
    private MenuPage menuPage;
    private AppPage appPage;

    @Before
    public void initialize() {
        driver = new FirefoxDriver();
        googleMain = new GooglePage(driver);
        playPage = new GooglePlayPage(driver);
        menuPage = new MenuPage(driver);
        appPage = new AppPage(driver);
    }

    // Couldn't make my mind if like this is better, or to create four tests and run them ordered
    // but as far as I know, it is pretty wrong to have ordered tests, so I left it like this.
    // used IntelliJ, that's why this is with org.junit.
    @org.junit.Test
    public void reviewsCount() {

        googleMain.navigate();
        googleMain.correctPageLoaded();
        googleMain.openMenu();

        menuPage.correctPageLoaded();
        menuPage.clickPlayStoreIcon();

        playPage.correctPageLoaded();
        playPage.useSearch("Testing");
        playPage.clickOnDesiredApp("Software Testing Concepts");

        appPage.correctPageLoaded();
        System.out.println(appPage.getReviewersCount());
        System.out.println(appPage.getStarRating());
    }

    @After
    public void clean() {
        driver.close();
    }
}
