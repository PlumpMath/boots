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
			Boots::Library::WorkBoots.setup
			@@canvas = Boots::Library::Canvas.new
			self.new.instance_eval(&script)
			Boots::Library::WorkBoots.run @@canvas
		end
	end
	
	def para(text)
		new_label = Boots::Library::Elements::Para.new
		new_label.text = text
		@@canvas.add_control new_label
		new_label
	end
	
	def button(text, *args, &event)
		new_button = Boots::Library::Elements::Button.new *args
		new_button.text = text
		new_button.click do
			event.call()
		end
		@@canvas.add_control new_button
		new_button
	end
	
	def stack(&script)
		new_stack = Boots::Library::Slots::Stack.new
		new_stack.
		new_stack
	end
end


Sneakers.app do
	@p = self.para "Hello!"
	@p.text = @p.text + " World! \\n It is on!	\\nand on and on..."
	
	button "Push me", :width => 0.5 do
		para "yeah"
	end
end

