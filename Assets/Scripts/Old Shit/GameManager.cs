//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.EventSystems;

///*
 
//    TO DO:
    
//    make all item managers inherit features from itemManager class

//    making distinct fenceVisible, dirtVisible variables might not be best way to do that

//    on final text advances hitting enter triggers negative sound
     
//     */

//public class GameManager : Singleton<GameManager>
//{

//    //game variables
//    private const int numItems = 11; //the number of items to guess
//    private int itemOn; //the slot in array user is on
//    private int numCorrect; //how many answers the user guessed correctly
//    private bool doneGuessing;
//    private bool bunnyTrigger;
//    private bool fenceBreakTrigger;
//    private bool critterTrigger;
//    private bool flyIsStopped;
//    private Animator cameraAnim;
//    private float finalTextBuffer = 1.2f;
//    private int finalPromptOn;

//    [SerializeField] private Animator feedbackAnim;
//    [SerializeField] private string feedbackAnimName;
//    [SerializeField] private GameObject penguin;
//    [SerializeField] private GameObject ebgCover;
//    [SerializeField] private GameObject audioObject;
//    [SerializeField] private AudioClip correctSound;
//    [SerializeField] private AudioClip incorrectSound;
//    [SerializeField] private AudioSource backgoundSong;
//    [SerializeField] private AudioSource ebgTheme;
//    [SerializeField] private AudioSource recordSound;
//    [SerializeField] private Text prompt;
//    [SerializeField] private Text feedback;
//    [SerializeField] private InputField userInput;
//    [SerializeField] private InputField finalInput;
//    [SerializeField] private Button choice1;
//    [SerializeField] private Button choice2;
//    [SerializeField] private Button choice3;
//    [SerializeField] private Button choice4;
//    [SerializeField] private Button next;
//    [SerializeField] private Button reset;
//    [SerializeField] private Button submit;
//    [SerializeField] private Button start;
//    [SerializeField] private Button changeModes;
//    [SerializeField] private Button quitButton;

//    private Button[] choices;

//    public bool CritterTrigger
//    {
//        get
//        {
//            return critterTrigger;
//        }
//    }

//    public bool BunnyTrigger
//    {
//        get
//        {
//            return bunnyTrigger;
//        }
//    }

//    public bool FenceBreakTrigger
//    {
//        get
//        {
//            return fenceBreakTrigger;
//        }
//    }

//    public bool FlyIsStopped
//    {
//        get
//        {
//            return flyIsStopped;
//        }
//    }

//    private struct guessItem
//    {
//        public string[] names;
//        public string clue;
//        public string[] choices;
//        public bool isGuessed;

//        public guessItem(string[] n, string c, string[] cho)
//        {
//            names = n;
//            clue = c;
//            choices = cho;
//            isGuessed = false;
//        }

//    }

//    private guessItem[] guessItems = new guessItem[numItems];

//    /*Item order 
//         0 Fence
//         1 Soil
//         2 Dragonfly
//         3 Bee
//         4 Ladybug
//         5 Snail
//         6 Worm
//         7 Carrot
//         8 Tomato
//         9 Flower
//         10 Lettuce
//    */


//    public bool FenceVisible
//    {
//        get
//        {
//            return guessItems[0].isGuessed;
//        }
//    }

//    public bool SoilVisible
//    {
//        get
//        {
//            return guessItems[1].isGuessed;
//        }
//    }

//    public bool DragonflyVisible
//    {
//        get
//        {
//            return guessItems[2].isGuessed;
//        }
//    }

//    public bool BeeVisible
//    {
//        get
//        {
//            return guessItems[3].isGuessed;
//        }
//    }

//    public bool LadybugVisible
//    {
//        get
//        {
//            return guessItems[4].isGuessed;
//        }
//    }

//    public bool SnailVisible
//    {
//        get
//        {
//            return guessItems[5].isGuessed;
//        }
//    }

//    public bool WormVisible
//    {
//        get
//        {
//            return guessItems[6].isGuessed;
//        }
//    }

//    public bool CarrotVisible
//    {
//        get
//        {
//            return guessItems[7].isGuessed;
//        }
//    }

//    public bool TomatoVisible
//    {
//        get
//        {
//            return guessItems[8].isGuessed;
//        }
//    }

//    public bool FlowerVisible
//    {
//        get
//        {
//            return guessItems[9].isGuessed;
//        }
//    }

//    public bool LettuceVisible
//    {
//        get
//        {
//            return guessItems[10].isGuessed;
//        }
//    }

//    private int count = 0;

//    private string[] finalQuestionText = new string[] { "Hey, I’ve already figured it out! Have you? ",
//                                                        "Right here in my own Dog Park - it's The Best Garden Ever!",
//                                                        "No wonder Food Lady was so busy! ",
//                                                        "My friends Goldie and Patches told me that gardens are a lot of hard work. I’ll bet they meant keeping it safe from danger! What kind of work do you think goes into taking care of a garden? Write your ideas in the box below." };

//    // Use this for initialization
//    void Start() {

//        //Debug.Log("Multiple guess mode: " + OpeningManager.IsMultipleChoiceMode);
//        choices = new Button[] { choice1, choice2, choice3, choice4 };
//        initializeGameVars();
//        initializeGuessItems();
//        cameraAnim = GetComponent<Animator>();
//        //StartCoroutine(displayText("The spot where Food Lady’s been digging and sprinkling water looks different. And it smells different, too. See if you can figure out each thing that’s new!"));
//        prompt.text = "The spot where Food Lady’s been digging and sprinkling water looks different. And it smells different, too. See if you can figure out each thing that’s new!";

//    }

//    // Update is called once per frame
//    void Update() {

//        if (!OpeningManager.IsMultipleChoiceMode && !doneGuessing) {

//            if (Input.GetKeyDown(KeyCode.Return))
//            {
//                getGuess(userInput.text);
//            }

//        }

//    }

//    void initializeGameVars() {

//        doneGuessing = false;
//        bunnyTrigger = false;
//        fenceBreakTrigger = false;
//        critterTrigger = false;
//        flyIsStopped = false;
//        numCorrect = 0;
//        itemOn = 0;
//        finalPromptOn = 0;
//        next.gameObject.SetActive(false);
//        //userInput.gameObject.SetActive(false);
//        finalInput.gameObject.SetActive(false);
//        submit.gameObject.SetActive(false);
//        reset.gameObject.SetActive(false);
//        changeModes.gameObject.SetActive(false);
//        quitButton.gameObject.SetActive(false);
//        FenceManager.needToReset = true;

//        foreach (Button choice in choices)
//        {
//            choice.gameObject.SetActive(false);
//        }
        

//    }

//    void resetGuessItems() // resets all guessItems to play again
//    {
//        for (int i = 0; i < numItems; i++)
//        {
//            guessItems[i].isGuessed = false;
//        }
//    }

//    public void resetGame()
//    {
//        initializeGameVars();
//        resetGuessItems();
//        bunny1.Instance.initializeGameVars();
//        bunny2.Instance.initializeGameVars();
//        bunny3.Instance.initializeGameVars();
//    }

//    void focusOnInput(InputField inputField)
//    {
//        //not my code focus on input box
//        EventSystem.current.SetSelectedGameObject(inputField.gameObject, null);
//        inputField.OnPointerClick(new PointerEventData(EventSystem.current));
//    }

//    void initializeGuessItems()
//    {
//        guessItems[0] = new guessItem(new string[] { "fence" }, "Hmmm... I smell wood! Posts rise up from the ground with rails going across them. The wooden posts surround this new area, like a border. What do you think it is?", new string[] { "Wall", "Curtain", "Fence", "Tree" });
//        guessItems[1] = new guessItem(new string[] { "dirt", "soil" }, "And over here, a patch of grass is missing. Sniff… sniff… The ground smells earthy and fresh. It’s soft and oh-so-fun to dig in! What is it?", new string[] { "Soil", "Rocks", "Rug", "Sand" });
//        guessItems[2] = new guessItem(new string[] { "dragonfly", "dragon fly" }, "Do you hear that buzzing sound over our heads? A fly is zooming like an airplane. It looks like an airplane, too! With a twig-like body and four skinny wings in the front like see-through propellers. What kind of creature is that?", new string[] { "Goose", "Dragonfly", "Mosquito", "Umbrella" });
//        guessItems[3] = new guessItem(new string[] { "bee" }, "Whoa! Something else is buzzing up there, too! It’s a bug or a fly with small wings and a fuzzy striped body. And its buzzing sure is loud! BZZZ! BZZZ! Good thing Hattie’s not here. She runs away when she sees one of these! What do you think it is?", new string[] { "Dandelion", "Butterfly", "Hummingbird", "Bee" });
//        guessItems[4] = new guessItem(new string[] { "ladybug", "lady bug" }, "And hey! Look down there on the ground! A round bug is crawling—no, she’s flying! Wait a minute, now she’s crawling again! Her head is solid black, but her body—which apparently is also her wings—is covered in dots. Do you know what kind of bug she is?", new string[] { "Ladybug", "Centipede", "Spider", "Hot Dog" });
//        guessItems[5] = new guessItem(new string[] { "snail" }, "What a cool shell over there. It’s curved and swirled, like a yummy cinnamon roll turned on its side. But it sure doesn’t smell one. Look at that—it’s MOVING! Very, very slowly. And I spy a head and a tail, but no legs. Do you know what this creature is?", new string[] { "Gecko", "Snail", "Crab", "Cake" });
//        guessItems[6] = new guessItem(new string[] { "worm" }, "Wowee! Somebody’s wiggling around in the dirt. It almost looks like a bit of string or a broken rubber band. It’s curly and squiggly and oh-so squirmy! What do you think it is?", new string[] { "Robin", "Ball", "Salamander", "Worm" });
//        guessItems[7] = new guessItem(new string[] { "carrot" }, "What is this plant sticking out of the ground? It smells vegetable-y. And when I dig around it, I notice a long root that's fat on top. I’ve seen this before in the Eating Place. Food Lady peels it. Hattie bites into it, and it makes a loud crunch. What is it?", new string[] { "Kale", "Watermelon", "Carrot", "Horse" });
//        guessItems[8] = new guessItem(new string[] { "tomato" }, "And what’s this other plant that’s taller than me? It smells kind of fruity, with leaves on a fuzzy, skinny stalk. And little plump balls hang from it. Fetch Man puts slices on sandwiches and hamburgers. Food Lady makes sauce from it for spaghetti or pizza. What is it?", new string[] { "Pepper", "Lemon", "Tomato", "Candle" });
//        guessItems[9] = new guessItem(new string[] { "flower" }, "Sniff… sniff… Yuck! What’s that perfume-y aroma? This plant has delicate petals on top of its thin, wispy stem. It reminds me of something Food Lady likes to put in a vase. What is it?", new string[] { "Coconut", "Flower", "Strawberry", "Onion" });
//        guessItems[10] = new guessItem(new string[] { "lettuce" }, "The wrinkly, ripple-y leaves over here are coming straight up from the ground in bunches. They smell crisp and sweet and they feel light and easy to rip or tear. They look like the leaves that Food Lady puts in salads. Do you know what it is?", new string[] { "Lettuce", "Pumpkin", "Peach", "Cheese" });
//    }

//    //get user's guess and check for correctness
//    public void getGuess(string guess)
//    {
//        bool isCorrect = false;
//        foreach (string name in guessItems[itemOn].names) {

//            if (guess.ToLower().Contains(name))
//            {                
//                isCorrect = true;
//                break;

//            }

//        }
//        if (isCorrect)
//        {
//            StartCoroutine(rightAnswer());

//        } else
//        {
//            feedback.text = "Ooh, try agian";
//            feedbackAnim.Play(feedbackAnimName);
//            audioObject.GetComponent<AudioSource>().PlayOneShot(incorrectSound);
//        }

//        userInput.text = "";
//        if (!OpeningManager.IsMultipleChoiceMode)
//            focusOnInput(userInput);

//    }

//    IEnumerator rightAnswer()
//    {
//        if (OpeningManager.IsMultipleChoiceMode)
//        {
//            foreach (Button choice in choices)
//            {
//                choice.gameObject.SetActive(false);
//            }
//        }
//        audioObject.GetComponent<AudioSource>().PlayOneShot(correctSound);
//        feedback.text = "";
//        prompt.text = "";
//        guessItems[itemOn].isGuessed = true;
//        itemOn++;
//        numCorrect++;
//        if (numCorrect == numItems)
//        {
//            doneGuessing = true;
//            userInput.gameObject.SetActive(false);
//            yield return new WaitForSeconds(0.7f);
//            //StartCoroutine(changeToFinalQuestion());
//            advanceFinalPrompt();
//        }
//        else
//        {
//            yield return new WaitForSeconds(0.7f);
//            updateClue();
//        }
//    }

//    void updateClue()
//    {
//        //StartCoroutine(displayText(guessItems[itemOn].clue));
//        prompt.text = guessItems[itemOn].clue;
//        if (OpeningManager.IsMultipleChoiceMode)
//        {
//            for (int i = 0; i < choices.Length; i++)
//            {
//                choices[i].gameObject.SetActive(true);
//                string option = guessItems[itemOn].choices[i];
//                choices[i].GetComponentInChildren<Text>().text = option;
//                // if text is too long for button
//                if(option.Length > 9)
//                {
//                    int fontSize = 20;
//                    // reduce font size for every extra letter
//                    for(int l = 10; l < option.Length; l++)
//                    {
//                        fontSize--;
//                    }
//                    choices[i].GetComponentInChildren<Text>().fontSize = fontSize;
//                } else
//                {
//                    choices[i].GetComponentInChildren<Text>().fontSize = 25;
//                }

//            }
//        }
//    }

//    public void advanceFinalPrompt()
//    {
//        next.gameObject.SetActive(false);
//        prompt.text = finalQuestionText[finalPromptOn];
//        finalPromptOn++;
//        if (finalPromptOn >= finalQuestionText.Length)
//        {
//            StartCoroutine(showLastQuestion());
//        }
//        else
//        {
//            StartCoroutine(showNextArrow());
//        }
//    }

//    IEnumerator showNextArrow()
//    {
//        yield return new WaitForSeconds(finalTextBuffer);
//        next.gameObject.SetActive(true);
//    }

//    IEnumerator showLastQuestion()
//    {
//        yield return new WaitForSeconds(finalTextBuffer);
//        finalInput.gameObject.SetActive(true);
//        submit.gameObject.SetActive(true);
//        focusOnInput(finalInput);
//    }

//    public void startBunnyScene()
//    {
//        prompt.text = "";
//        finalInput.gameObject.SetActive(false);
//        submit.gameObject.SetActive(false);
//        cameraAnim.Play("shake");
//        StartCoroutine(placeResetButton());
//        StartCoroutine(playEBGTheme());
//    }

//    IEnumerator playEBGTheme()
//    {
//        backgoundSong.Stop();
//        recordSound.Play();
//        yield return new WaitForSeconds(1.5f);
//        ebgTheme.Play();
//    }

//    IEnumerator placeResetButton()
//    {
//        yield return new WaitForSeconds(24);
//        prompt.text = "Oh no! How am I going to handle a gang of Evil Bunnies? Find out in my second book, available wherever books are sold.";
//        SpriteRenderer penguinSprite = penguin.GetComponent<SpriteRenderer>();
//        SpriteRenderer ebgSprite = ebgCover.GetComponent<SpriteRenderer>();
//        penguinSprite.sortingLayerName = "guessItems";
//        penguinSprite.sortingOrder = 6;
//        ebgSprite.sortingLayerName = "guessItems";
//        ebgSprite.sortingOrder = 6;
//        reset.gameObject.SetActive(true);
//        changeModes.gameObject.SetActive(true);
//        //quitButton.gameObject.SetActive(true);
//    }

//    public void enterBunny1()
//    {
//        bunnyTrigger = true;
//    }

//    public void flee()
//    {
//        critterTrigger = true;
//    }

//    public void killDragonfly()
//    {
//        flyIsStopped = true;
//    }

//    public void startGame()
//    {
//        ebgTheme.Stop();
//        //var startButton
//        if (!OpeningManager.IsMultipleChoiceMode)        
//        {
//            // if not multiple guess mode, make inputField active
//            userInput.gameObject.SetActive(true);
//            focusOnInput(userInput);
//        }

//        updateClue();
//        start.gameObject.SetActive(false);
//        audioObject.GetComponent<AudioSource>().PlayOneShot(correctSound);
//        StartCoroutine(playMainTheme());
//    }

//    IEnumerator playMainTheme()
//    {
//        yield return new WaitForSeconds(0.3f);
//        backgoundSong.Play();
//    }

//    // Should combine the following into one generic function
//    // How to get this.text?

//    public void getButtonGuess1()
//    {
//        Text btnText = choice1.GetComponentInChildren<Text>();
//        getGuess(btnText.text);
//    }

//    public void getButtonGuess2()
//    {
//        getGuess(choice2.GetComponentInChildren<Text>().text);
//    }

//    public void getButtonGuess3()
//    {
//        getGuess(choice3.GetComponentInChildren<Text>().text);
//    }

//    public void getButtonGuess4()
//    {
//        getGuess(choice4.GetComponentInChildren<Text>().text);
//    }

//    public void stopEBGMusic()
//    {
//        ebgTheme.Stop();
//    }

//    public void stopMainTheme()
//    {
//        backgoundSong.Stop();
//    }

//}
