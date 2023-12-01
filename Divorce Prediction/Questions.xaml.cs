using System.Net.Http.Headers;

namespace Divorce_Prediction;

public partial class Questions : ContentPage
{
    Button[] buttons;
    int[] answers;
    int currentIndex;
    Dictionary<string, string> questions_en;
    Dictionary<string, string> questions_tr;
    Dictionary<int, string> answers_en;
    Dictionary<int, string> answers_tr;
    public Questions()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        answers = new int[54];
        buttons = new Button[] { button1, button2, button3, button4, button5 };
        questions_en = new Dictionary<string, string>
        {
            { "q1", "If one of us apologizes when our discussion deteriorates, the discussion ends."},
            { "q2", "I know we can ignore our differences, even if things get hard sometimes."},
            { "q3", "When we need it, we can take our discussions with my spouse from the beginning and correct it."},
            { "q4", "When I discuss with my spouse, to contact him will eventually work."},
            { "q5", "The time I spent with my wife is special for us."},
            { "q6", "We don't have time at home as partners."},
            { "q7", "We are like two strangers who share the same environment at home rather than family."},
            { "q8", "I enjoy our holidays with my wife."},
            { "q9", "I enjoy traveling with my wife."},
            { "q10", "Most of our goals are common to my spouse."},
            { "q11", "I think that one day in the future, when I look back, I see that my spouse and I have been in harmony with each other."},
            { "q12", "My spouse and I have similar values in terms of personal freedom."},
            { "q13", "My spouse and I have similar sense of entertainment."},
            { "q14", "Most of our goals for people (children, friends, etc.) are the same."},
            { "q15", "Our dreams with my spouse are similar and harmonious."},
            { "q16", "We're compatible with my spouse about what love should be."},
            { "q17", "We share the same views about being happy in our life with my spouse."},
            { "q18", "My spouse and I have similar ideas about how marriage should be."},
            { "q19", "My spouse and I have similar ideas about how roles should be in marriage."},
            { "q20", "My spouse and I have similar values in trust."},
            { "q21", "I know exactly what my wife likes."},
            { "q22", "I know how my spouse wants to be taken care of when she/he sick."},
            { "q23", "I know my spouse's favorite food."},
            { "q24", "I can tell you what kind of stress my spouse is facing in her/his life."},
            { "q25", "I have knowledge of my spouse's inner world."},
            { "q26", "I know my spouse's basic anxieties."},
            { "q27", "I know what my spouse's current sources of stress are."},
            { "q28", "I know my spouse's hopes and wishes."},
            { "q29", "I know my spouse very well."},
            { "q30", "I know my spouse's friends and their social relationships."},
            { "q31", "I feel aggressive when I argue with my spouse."},
            { "q32", "When discussing with my spouse, I usually use expressions such as ‘you always’ or ‘you never’."},
            { "q33", "I can use negative statements about my spouse's personality during our discussions."},
            { "q34", "I can use offensive expressions during our discussions."},
            { "q35", "I can insult my spouse during our discussions."},
            { "q36", "I can be humiliating when we discussions."},
            { "q37", "My discussion with my spouse is not calm."},
            { "q38", "I hate my spouse's way of open a subject."},
            { "q39", "Our discussions often occur suddenly."},
            { "q40", "We're just starting a discussion before I know what's going on."},
            { "q41", "When I talk to my spouse about something, my calm suddenly breaks."},
            { "q42", "When I argue with my spouse, ý only go out and I don't say a word."},
            { "q43", "I mostly stay silent to calm the environment a little bit."},
            { "q44", "Sometimes I think it's good for me to leave home for a while."},
            { "q45", "I'd rather stay silent than discuss with my spouse."},
            { "q46", "Even if I'm right in the discussion, I stay silent to hurt my spouse."},
            { "q47", "When I discuss with my spouse, I stay silent because I am afraid of not being able to control my anger."},
            { "q48", "I feel right in our discussions."},
            { "q49", "I have nothing to do with what I've been accused of."},
            { "q50", "I'm not actually the one who's guilty about what I'm accused of."},
            { "q51", "I'm not the one who's wrong about problems at home."},
            { "q52", "I wouldn't hesitate to tell my spouse about her/his inadequacy."},
            { "q53", "When I discuss, I remind my spouse of her/his inadequacy."},
            { "q54", "I'm not afraid to tell my spouse about her/his incompetence."},
        };
        questions_tr = new Dictionary<string, string>
        {
            { "q1", ""},
            { "q2", ""},
            { "q3", ""},
            { "q4", ""},
            { "q5", ""},
            { "q6", ""},
            { "q7", ""},
            { "q8", ""},
            { "q9", ""},
            { "q10", ""},
            { "q11", ""},
            { "q12", ""},
            { "q13", ""},
            { "q14", ""},
            { "q15", ""},
            { "q16", ""},
            { "q17", ""},
            { "q18", ""},
            { "q19", ""},
            { "q20", ""},
            { "q21", ""},
            { "q22", ""},
            { "q23", ""},
            { "q24", ""},
            { "q25", ""},
            { "q26", ""},
            { "q27", ""},
            { "q28", ""},
            { "q29", ""},
            { "q30", ""},
            { "q31", ""},
            { "q32", ""},
            { "q33", ""},
            { "q34", ""},
            { "q35", ""},
            { "q36", ""},
            { "q37", ""},
            { "q38", ""},
            { "q39", ""},
            { "q40", ""},
            { "q41", ""},
            { "q42", ""},
            { "q43", ""},
            { "q44", ""},
            { "q45", ""},
            { "q46", ""},
            { "q47", ""},
            { "q48", ""},
            { "q49", ""},
            { "q50", ""},
            { "q51", ""},
            { "q52", ""},
            { "q53", ""},
            { "q54", ""},
        };
        answers_en = new Dictionary<int, string>
        {
            {0, "Strongly Agree" },
            {1, "Agree" },
            {2, "Not Sure" },
            {3, "Disagree" },
            {4, "Strongly Disagree" },
        };
        answers_tr = new Dictionary<int, string>
        {
            {0, "Kesinlikle Katýlýyorum" },
            {1, "Katýlýyorum" },
            {2, "Emin Deðilim" },
            {3, "Katýlmýyorum" },
            {4, "Kesinlikle Katýlmýyorum" }
        };
        currentIndex = 0;
        for(int i=0; i<buttons.Length; i++)
        {
            buttons[i].WidthRequest = 400;
            buttons[i].Text = answers_en[i];
        }
    }
  
    private void ChangeAnswer(int answer)
    {
        if(answer == -1)
        {
            foreach (Button button in buttons)
            {
                button.BackgroundColor = Color.FromArgb("#fff");
                button.TextColor = Color.FromArgb("#000");
            }
            return;
        }
        buttons[answer].BackgroundColor = buttons[answer].BorderColor;
        buttons[answer].TextColor = Color.FromArgb("#fff");
        foreach (Button button in buttons)
        {
            if(button == buttons[answer])
            {
                continue;
            }
            button.BackgroundColor = Color.FromArgb("#fff");
            button.TextColor = Color.FromArgb("#000");
        }
        answers[currentIndex] = answer;
    }
    private void button1_Clicked(object sender, EventArgs e)
    {
        ChangeAnswer(0);
    }

    private void button2_Clicked(object sender, EventArgs e)
    {
        ChangeAnswer(1);
    }

    private void button3_Clicked(object sender, EventArgs e)
    {
        ChangeAnswer(2);
    }

    private void button4_Clicked(object sender, EventArgs e)
    {
        ChangeAnswer(3);
    }

    private void button5_Clicked(object sender, EventArgs e)
    {
        ChangeAnswer(4);
    }

    private void buttonNext_Clicked(object sender, EventArgs e)
    {
        if (currentIndex < 53) currentIndex++;
        string questionIndex = "q" + (currentIndex + 1).ToString();
        qLabel.Text = questions_en[questionIndex];
        
    }

    private void buttonBack_Clicked(object sender, EventArgs e)
    {
        if (currentIndex > 0) currentIndex--;
        string questionIndex = "q" + (currentIndex + 1).ToString();
        qLabel.Text = questions_en[questionIndex];
        
    }
}