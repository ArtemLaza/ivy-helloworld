namespace IvyHelloworld.Apps;

[App(icon:Icons.PartyPopper, title:"Hello")]
public class HelloApp : ViewBase
{
    public override object? Build()
    {
        var nameInput = this.UseState<string>();
        var displayName = this.UseState<string>("");

        return Layout.Center()
               | (new Card(
                    Layout.Vertical().Gap(6).Padding(2).Align(Align.Center)
                   | new Confetti(new IvyLogo())
                   | Text.H2("Hello " + (string.IsNullOrEmpty(displayName.Value) ? "there" : displayName.Value) + "!")
                   | Text.Block("Welcome to the fantastic world of Ivy. Let's build something amazing together!")
                   | nameInput.ToInput(placeholder: "What is your name?")
                   | new Button("Say Hello!", onClick: _ => displayName.Value = nameInput.Value)
                   | new Separator()
                   | Text.Markdown("You'd be a hero to us if you could ⭐ us on [Github](https://github.com/Ivy-Interactive/Ivy-Framework)")
                 )
                 .Width(Size.Units(120).Max(500)));
    }
}