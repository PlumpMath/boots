class Sneakers
	
	class << self
		def app(&script)
			@@canvas = "Hello!"
			self.new.instance_eval(&script)
		end
	end
	
	def label(text, *args)
		@@canvas = @@canvas + text
		puts @@canvas
	end
end

Sneakers.app do
	label "World!", :width => 0.5, :height => 0.5
end