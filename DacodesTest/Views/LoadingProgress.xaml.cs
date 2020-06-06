using Lottie.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingProgress : ContentView
    {

        #region [ Constantes ]
        #endregion

        #region [ Atributos ]
        #endregion

        #region [ Variables ]
        #endregion

        #region [ Propiedades ]

        #region [ SubtitleBindableProperty ]
        public static readonly BindableProperty SubtitleProperty = BindableProperty.Create(
            propertyName: "DialogSubtitle",
            returnType: typeof(string),
            declaringType: typeof(LoadingProgress),
            defaultValue: "Espere un momento por favor...");
        public string DialogSubtitle
        {
            get { return (string)GetValue(SubtitleProperty); }
            set { SetValue(SubtitleProperty, value); }
        }
        #endregion

        #region [ AnimationBindableProperty ]
        public static readonly BindableProperty AnimationProperty = BindableProperty.Create(
            propertyName: "DialogAnimation",
            returnType: typeof(string),
            declaringType: typeof(LoadingProgress),
            defaultValue: "soccer.json");
        public string DialogAnimation
        {
            get { return (string)GetValue(AnimationProperty); }
            set { SetValue(AnimationProperty, value); }
        }
        #endregion

        #endregion

        #region [ Constructor ]
        public LoadingProgress()
        {
            InitializeComponent();

            #region [ Bindings ]
            Subtitle.SetBinding(Label.TextProperty, new Binding(nameof(DialogSubtitle), BindingMode.TwoWay, null, null, null, this));
            LottieAnimation.SetBinding(AnimationView.AnimationProperty, new Binding(nameof(DialogAnimation), BindingMode.TwoWay, null, null, null, this));
            #endregion
        }
        #endregion

        #region [ Metodos/Comandos ]
        #endregion
    }
}