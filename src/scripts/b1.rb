require 'mscorlib' 
require 'System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' 
require 'C:\Dev\Projects\Boots\src\Boots.Library\bin\Debug\Boots.Library.dll'

#Boots::Library::Boots.setup

#@canvas = Boots::Library::Canvas.new

#@p1 = Boots::Library::Elements::Para.new
#@p1.text = "Hello!"
#@p2 = Boots::Library::Elements::Para.new
#@p2.text = "World!"

#@canvas.AddControl @p1
#@canvas.AddControl @p2

#Boots::Library::Boots.run @canvas



class Sneakers
	class << self
		def app(&script)
			Boots::Library::Boots.setup
			@@canvas = Boots::Library::Canvas.new
			self.new.instance_eval(&script)
			Boots::Library::Boots.run @@canvas
		end
	end
	
	def label(text)
		new_label = Boots::Library::Elements::Para.new
		new_label.text = text
		@@canvas.AddControl new_label
		new_label
	end
end


Sneakers.app do
	@p = self.label "Hello!"
	@p.text = @p.text + " World! \n It is on!	"
end

