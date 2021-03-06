﻿require 'mscorlib' 
require 'System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' 
require 'C:\Dev\Projects\Boots\src\Boots.Library\bin\Debug\Boots.Library.dll'

class Boots
	class << self
		def app(&script)
			SteelToeBoots::Library::WorkBoots.setup
			canvas = SteelToeBoots::Library::Canvas.new
			@@current_container = Array.new
			@@current_container.push canvas
			self.new.instance_eval(&script)
			SteelToeBoots::Library::WorkBoots.run canvas
		end
	end
	
	def para(text)
		new_label = SteelToeBoots::Library::Elements::Para.new
		new_label.text = text
		@@current_container.last.add_control new_label
		new_label
	end
	
	def button(text, *args, &event)
		new_button = SteelToeBoots::Library::Elements::Button.new *args
		new_button.text = text
		new_button.click do
			event.call()
		end
		@@current_container.last.add_control new_button
		new_button
	end
	
	def stack(*args, &script)
		new_stack = SteelToeBoots::Library::Slots::Stack.new *args
		@@current_container.last.add_control new_stack
		@@current_container.push new_stack
		self.instance_eval &script
		@@current_container.pop
		new_stack
	end
	
	def alert(message)
		SteelToeBoots::Library::Builtins::Dialogs::Alert.show message
	end
	
	def ask(message)
		SteelToeBoots::Library::Builtins::Dialogs::Ask.show message
	end
end

def del(text)
	"<del>" + text + "</del>"
end

def em(text)
	"<em>" + text + "</em>"
end

def ins(text)
	"<em>" + text + "</em>"
end

def strong(text)
	"<strong>" + text + "</strong>"
end