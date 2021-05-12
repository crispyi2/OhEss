#include "system_assets.h"

#include "imgui.h"
#include "imgui_impl_sdl.h"
#include "imgui_impl_opengl3.h"
#include <stdio.h>
#include <emscripten.h>
#include <SDL.h>
#include <SDL_opengles2.h>

bool LoadTextureFromFile(const char* filename, GLuint* out_texture, int* out_width, int* out_height)
{
    // Load from file
    int image_width = 0;
    int image_height = 0;
    unsigned char* image_data = stbi_load(filename, &image_width, &image_height, NULL, 4);
    if (image_data == NULL)
        return false;

    // Create a OpenGL texture identifier
    GLuint image_texture;
    glGenTextures(1, &image_texture);
    glBindTexture(GL_TEXTURE_2D, image_texture);

    // Setup filtering parameters for display
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_CLAMP_TO_EDGE); // This is required on WebGL for non power-of-two textures
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_CLAMP_TO_EDGE); // Same

    // Upload pixels into texture
#if defined(GL_UNPACK_ROW_LENGTH) && !defined(__EMSCRIPTEN__)
    glPixelStorei(GL_UNPACK_ROW_LENGTH, 0);
#endif
    glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, image_width, image_height, 0, GL_RGBA, GL_UNSIGNED_BYTE, image_data);
    stbi_image_free(image_data);

    *out_texture = image_texture;
    *out_width = image_width;
    *out_height = image_height;

    return true;
}
/**\
* Images
*/

/**\
* logo image
*/
int loadAssets();
{
    int logo_width = 0;
    int logo_height = 0;
    GLuint logo_texture = 0;
    bool LogoImage = LoadTextureFromFile("./system_assets/logos/Logo.png", &logo_texture, &logo_width, &logo_height);
    IM_ASSERT(LogoImage);
}

/**\
* test image
*/
int my_image_width = 0;
int my_image_height = 0;
GLuint my_image_texture = 0;
bool ret = LoadTextureFromFile("./system_assets/MyImage01.jpg", &my_image_texture, &my_image_width, &my_image_height);
IM_ASSERT(ret);


/**\
* // test image
*
* int my_image_width = 0;
* int my_image_height = 0;
* GLuint my_image_texture = 0;
* bool ret = LoadTextureFromFile("./system_assets/MyImage01.jpg", &my_image_texture, &my_image_width, &my_image_height);
* IM_ASSERT(ret);
*/

/**\
* Audio
*/

/***\
** Music
**/

/***\
** SFX
**/