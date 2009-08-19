require 'mscorlib'
require 'PresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
require 'PresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'

Window = System::Windows::Window
Application = System::Windows::Application
Button = System::Windows::Controls::Button

win = Window.new
win.title = 'IronRuby and WPF Interop'

mainButton = Button.new
mainButton.content = 'I am a WPF button — press me'

mainButton.click do |sender, args|
  System::Windows::MessageBox.Show("Created using IronRuby!")
end

win.content = mainButton
my_app = Application.new
my_app.run win

#Boots.setup
#Boots.run


#require 'mscorlib' 
#require 'System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' 
#require 'C:\Dev\Projects\Boots\src\Boots.Library\bin\Debug\Boots.Library.dll'