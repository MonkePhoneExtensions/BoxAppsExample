using MonkePhone.Behaviours;
using MonkePhone.Behaviours.UI;

namespace BoxAppsExample.Apps
{
    public class ExampleApp : PhoneApp
    {
        /// <summary>
        /// The AppId Property is the unique identifier the phone uses to open the app.
        /// </summary>
        public override string AppId => "Example";

        /// <summary>
        /// The Initialize method is invoked once when the app is first created by the phone.
        /// </summary>
        public override void Initialize()
        {

        }

        /// <summary>
        /// The Update method is invoked every frame while the app is running.
        /// </summary>
        public override void Update(bool isBackgroundApp)
        {

        }

        /// <summary>
        /// The AppOpened method is invoked when the app has been opened by the phone.
        /// </summary>
        public override void AppOpened()
        {

        }

        /// <summary>
        /// The AppClosed method is invoked when the app has been closed by the phone.
        /// </summary>
        public override void AppClosed()
        {

        }

        /// <summary>
        /// The ButtonClick method is invoked when a button contained in the app has been clicked. (i.e. a PhoneButton)
        /// </summary>
        public override void ButtonClick(PhoneUIObject phoneUIObject, bool isLeftHand)
        {

        }

        /// <summary>
        /// The ButtonTicked method is invoked when a button contained in the app has been ticked. (i.e. a PhoneCheckbox or PhoneSwitch)
        /// </summary>
        public override void ButtonTicked(PhoneUIObject phoneUIObject, bool currentValue, bool isLeftHand)
        {

        }

        /// <summary>
        /// The SliderUpdated method is invoked when a slider contained in the app has been updated. (i.e. a PhoneSlider)
        /// </summary>
        public override void SliderUpdated(PhoneUIObject phoneUIObject, float currentValue, bool isSelected)
        {

        }
    }
}