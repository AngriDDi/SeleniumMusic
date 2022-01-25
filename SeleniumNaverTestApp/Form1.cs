using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using MetroFramework.Forms;
using MetroFramework.Components;
using MetroFramework;

namespace SeleniumAutoMusicApp
{
    public partial class Form1 : MetroForm
    {

        protected ChromeDriverService driverService = null;
        protected ChromeOptions options = null;
        protected ChromeDriver driver = null;

        public Form1()
        {
            InitializeComponent();
            //!드라이버 서비스 추가
            driverService = ChromeDriverService.CreateDefaultService();
            //!true 숨기기, false 보이기
            driverService.HideCommandPromptWindow = true;

            options = new ChromeOptions();
            options.AddArgument("disable-gpu");//!disable-gpu
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += Form_Closing;
            StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroColorStyle.Magenta;

        }

        public void Form_Closing(object sender, FormClosedEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
                writeRichLog(($"[{DateTime.Now}] : Driver 제거 완료."));
            }
        }

        void muteSount(bool type)
        {
            string a = "";
            if (type)
            {
                a = "100% 볼륨";
                writeRichLog(($"[{DateTime.Now}] : 음소거 해제 완료."));
            }
            else {
                a = "100% 볼륨 음소거됨";
                writeRichLog(($"[{DateTime.Now}] : 음소거 완료."));
            }

            var muteString = driver.FindElement(By.XPath(@"//*[@id='movie_player']/div/div/div/span/div")).GetAttribute("aria-valuetext");//!음소거버튼

            if (muteString == a)
            {
                driver.FindElement(By.XPath(@"//*[@id='movie_player']/div/div[2]/div[1]/span/button")).Click();
            }
        }

        private void writeRichLog(string log)
        {
            if (LogBox.Text.Length > 3_000) LogBox.Text = ""; // 3000자 표현후 텍스트 클리어. (성능 부분 고려) 
            LogBox.AppendText(log + Environment.NewLine);
            LogBox.SelectionStart = LogBox.Text.Length;
        }

        private void Start_Click(object sender, EventArgs e)
        {            
            driver = new ChromeDriver(driverService, options);
            Console.WriteLine("error");
            writeRichLog(($"[{DateTime.Now}] : Driver 생성 완료."));
            try
            {
                driver.Navigate().GoToUrl("https://www.youtube.com/results?search_query=%EB%A9%9C%EB%A1%A0+100");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            catch (Exception ex)
            {
               writeRichLog(($"[{DateTime.Now}] : 웹페이지 오픈 실패,  사유 : .{ ex }"));
               return;
            }

            writeRichLog(($"[{DateTime.Now}] : 웹페이지 오픈."));

            try
            {
                driver.FindElement(By.XPath(@"//*[@id='contents']/ytd-video-renderer[1]")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            }
            catch
            {
                writeRichLog(($"[{DateTime.Now}] : 항목 선택 실패."));
            }

            writeRichLog(($"[{DateTime.Now}] : 항목 선택 완료."));
            muteSount(true);


            writeRichLog(($"[{DateTime.Now}] : 광고 건너뛰기 감지 시작."));
            while (true)
            {
                bool skip = driver.FindElement(By.XPath(@"//div[text()='광고 건너뛰기']")).Displayed;//!광고 건너뛰기 찾기
                if (skip)
                {
                    driver.FindElement(By.XPath(@"//div[text()='광고 건너뛰기']")).Click();//!광고 건너뛰기 찾을시 클릭
                    break;
                }
            }

            writeRichLog(($"[{DateTime.Now}] : 광고 건너뛰기 완료."));
            IWebElement searchBtn = driver.FindElement(By.XPath("//*[@id='movie_player']/div[1]"));
            Actions actionProvider = new Actions(driver);
            actionProvider.ContextClick(searchBtn).Build().Perform();//!마우스 오른쪽 클릭
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath(@"//div[text()='연속 재생']")).Click();//!광고 건너뛰기 찾을시 클릭

            writeRichLog(($"[{DateTime.Now}] : 반복 재생 시작"));

            muteSount(false);
        }
    }
}
