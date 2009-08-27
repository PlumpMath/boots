class Sneakers
	
	class << self
		def app(&script)
			@@canvas = "Hello!"
			self.new.instance_eval(&script)
		end
	end
	
	def label(text)
		@@canvas = @@canvas + text
		puts @@canvas
	end
end

Sneakers.app do
	label "World!"
end